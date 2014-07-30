Imports AdvantageMessaging
Imports AdvantageMessaging.Data
Imports AdvantageMessaging.Service
Imports AdvantageMessaging.Service.Models
Imports AdvCommon

Public Class CoreServiceMessageHandler
    Inherits MessageHandlerBase
    Implements ICoreServiceMessageHandler

#Region " get message body "
    ''' <summary>
    ''' Updated the local list of message bodies from the remote data store. 
    ''' </summary>
    ''' <remarks></remarks>
    Public Overridable Sub GetMessageBodies() Implements ICoreServiceMessageHandler.GetMessageBodies
        Try
            Dim messageBodyList As New List(Of MessageModel)

            Using dbContext As New MessageDataContext()
                messageBodyList = dbContext.Messages.Where(Function(b) String.IsNullOrEmpty(b.Body))


                If (messageBodyList Is Nothing) OrElse (messageBodyList.Count = 0) Then
                    Return
                End If

                For Each messageWithoutBody As MessageModel In messageBodyList
                    messageWithoutBody.Body = GetMessageBody(messageWithoutBody.MessageId)
                Next

                dbContext.SaveChanges()

            End Using

        Catch ex As Exception
            LogException(ex)

        End Try

    End Sub

    ''' <summary>
    ''' Loads the body of the message
    ''' </summary>
    ''' <param name="messageId">The id of the message to load the body for.</param>
    Public Function GetMessageBody(messageId As Guid) As String Implements ICoreServiceMessageHandler.GetMessageBody
        Dim messageBody As String = String.Empty

        Using service = New MessageBodyService()
            messageBody = service.GetMessageBody(messageId)
        End Using

        Return messageBody

    End Function

#End Region

#Region " process expired messages "
    ''' <summary>
    ''' Updated the local list of message bodies from the remote data store. 
    ''' </summary>
    ''' <remarks></remarks>
    Public Overridable Sub ProcessExpiredMessages() Implements ICoreServiceMessageHandler.ProcessExpiredMessages
        Try
            Using dbContext As New MessageDataContext()
                Dim expirationTimestamp As DateTime = DateTime.Now

                Dim expiredMessages = dbContext.MessageSchedules.Where(Function(e) e.Expires <= expirationTimestamp AndAlso e.MessageEmployees.Any(Function(v) Not v.Viewed.HasValue))

                If (Not expiredMessages Is Nothing) AndAlso (expiredMessages.Count > 0) Then
                    For Each expiredMessage As MessageScheduleModel In expiredMessages
                        For Each messageView As MessageEmployeeModel In expiredMessage.MessageEmployees
                            messageView.Viewed = DateTime.MinValue
                            messageView.IsStatUpdated = True
                        Next

                    Next

                    dbContext.SaveChanges()

                End If

            End Using

        Catch ex As Exception
            LogException(ex)

        End Try
    End Sub

#End Region

#Region " update message list "
    ''' <summary>
    ''' Sends the local message stats to the remote data store.
    ''' </summary>
    ''' <remarks></remarks>
    Public Overridable Sub UpdateMessageList() Implements ICoreServiceMessageHandler.UpdateMessageList
        Try
            Dim messageList As New List(Of MessageListResponseModel)

            Using service = New MessageService()
                messageList = service.GetMessages(GetLocationHash())
            End Using

            If Not (messageList Is Nothing) AndAlso (messageList.Count > 0) Then
                LoadNewMessages(messageList)
            End If

        Catch ex As Exception
            LogException(ex)

        End Try

    End Sub

    Protected Friend Overridable Sub LoadNewMessages(messageList As List(Of MessageListResponseModel))
        Using dbContext As New MessageDataContext()

            Dim receivedTimestamp As DateTime = DateTime.Now()

            For Each message As MessageListResponseModel In messageList

                Dim localMessage = dbContext.Messages.FirstOrDefault(Function(m) m.MessageId = message.messageId)

                If localMessage Is Nothing Then
                    localMessage = AddMessage(message, dbContext)

                    Dim messageSchedule = AddMessageScheduleToMessage(message, receivedTimestamp, dbContext)

                    AddViewersToMessageSchedule(messageSchedule, dbContext)

                Else
                    If message.lastUpdate > localMessage.LastUpdate Then
                        localMessage.Body = String.Empty
                        localMessage.LastUpdate = message.lastUpdate

                    End If

                End If

            Next

            dbContext.SaveChanges()

        End Using

    End Sub

    Protected Friend Overridable Function AddMessage(message As MessageListResponseModel, dbContext As MessageDataContext) As MessageModel
        Dim localMessage = New MessageModel() With {
            .MessageId = message.messageId,
            .Subject = message.subject,
            .LastUpdate = message.lastUpdate}

        dbContext.Messages.Add(localMessage)

        Return localMessage

    End Function

    Protected Friend Overridable Function AddMessageScheduleToMessage(message As MessageListResponseModel, receivedTimestamp As DateTime, dbContext As MessageDataContext) As MessageScheduleModel
        Dim messageSchedule As New MessageScheduleModel() With {
            .MessageId = message.messageId,
            .MessageScheduleId = message.messageScheduleId,
            .Received = receivedTimestamp,
            .Expires = message.expires}

        dbContext.MessageSchedules.Add(messageSchedule)

        Return messageSchedule

    End Function

    Protected Friend Overridable Sub AddViewersToMessageSchedule(messageSchedule As MessageScheduleModel, dbContext As MessageDataContext)
        Dim employeeList = GetEmployeeList(dbContext)

        For Each employeeNumber As Integer In employeeList

            Dim messageEmployee As New MessageEmployeeModel() With {
                .MessageEmployeeId = Guid.NewGuid(),
                .MessageScheduleId = messageSchedule.MessageScheduleId,
                .EmployeeNo = employeeNumber,
                .IsRead = False,
                .IsStatUpdated = False}

            dbContext.MessageEmployees.Add(messageEmployee)

        Next

    End Sub

    Protected Friend Overridable Function GetEmployeeList(dbContext As MessageDataContext) As List(Of Integer)
        Dim sql = "SELECT dbo.SecurityGroupMembers.EmpNo FROM dbo.SecurityRights INNER JOIN dbo.SecurityAccess ON dbo.SecurityRights.RightID = dbo.SecurityAccess.RightID INNER JOIN dbo.SecurityApps ON dbo.SecurityRights.AppID = dbo.SecurityApps.AppID INNER JOIN dbo.SecurityCategories ON dbo.SecurityRights.CategoryID = dbo.SecurityCategories.CategoryID INNER JOIN dbo.SecurityGroups INNER JOIN dbo.SecurityGroupMembers ON dbo.SecurityGroups.GroupID = dbo.SecurityGroupMembers.GroupID ON dbo.SecurityAccess.SID = dbo.SecurityGroups.GroupID WHERE (dbo.SecurityGroups.Enabled = 1) AND (dbo.SecurityGroups.GroupID = 7) AND (dbo.SecurityApps.AppID = 2) AND (dbo.SecurityAccess.RightID = 33) AND (dbo.SecurityCategories.CategoryID = 14)"

        Return dbContext.Database.SqlQuery(Of Integer)(sql).ToList()

    End Function

#End Region

#Region " update message stats "
    ''' <summary>
    ''' Updates the state of the local messages as they expire.
    ''' </summary>
    ''' <remarks></remarks>
    Public Overridable Sub UpdateMessageStats() Implements ICoreServiceMessageHandler.UpdateMessageStats
        Try
          
            Using dbContext As New MessageDataContext()

                Dim locationHash As String = GetLocationHash()

                Dim location As New MessageLocationModel(locationHash)

                Dim currentMessageScheduleId As Guid = Guid.Empty

                For Each employee As MessageEmployeeModel In dbContext.MessageEmployees.Where(Function(v) v.Viewed.HasValue AndAlso Not v.IsStatUpdated).OrderBy(Function(o) o.MessageScheduleId).ToList()

                    If (currentMessageScheduleId.Equals(Guid.Empty)) Then
                        currentMessageScheduleId = employee.MessageScheduleId
                    End If

                    If Not (employee.MessageScheduleId.Equals(currentMessageScheduleId)) Then

                    End If

                    Dim messageReader As New MessageViewerModel(employee.EmployeeNo, GetEmployeeName(employee.EmployeeNo), employee.Viewed.Value)
                    location.readBy.Add(messageReader)
                    'Next

                    

                    Dim requestModel As New MessageStatRequestModel(location)

                    Using statService As IMessageStatsService = New MessageStatsService()
                        statService.UpdateMessageStats(requestModel)
                    End Using

                    'For Each employee As MessageEmployeeModel In dbContext.MessageEmployees.Where(Function(v) v.Viewed.HasValue AndAlso Not v.IsStatUpdated).ToList()
                    employee.IsStatUpdated = True

                Next

                dbContext.SaveChanges()

            End Using

        Catch ex As Exception
            LogException(ex)

        End Try

    End Sub

#End Region

End Class
