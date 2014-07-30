Imports AdvantageMessaging.Data
Imports AdvantageMessaging.Logic
Imports System.Linq

Public Class MessageHandler
    Inherits MessageHandlerBase
    Implements IMessageHandler

#Region " ctor "
    ''' <summary>
    ''' Private constructor for MessageHandler.
    ''' </summary>
    ''' <param name="employeeNumber">The employee number of the employee associated with this instance of MessageHandler.</param>
    ''' <remarks>Use the factory method CreateNewHandler for instantiation.</remarks>
    Private Sub New(employeeNumber As Integer)
        MyBase.New(employeeNumber)
    End Sub

    ''' <summary>
    ''' Protected constructor for MessageHandler.
    ''' </summary>
    ''' <param name="employeeNumber">The employee number of the employee associated with this instance of MessageHandler.</param>
    ''' <param name="dbContext">External MessageDataContext to use as the data store.</param>
    ''' <remarks></remarks>
    Protected Sub New(employeeNumber As Integer, dbContext As MessageDataContext)
        MyBase.New(employeeNumber, dbContext)
    End Sub

#End Region

#Region " factory "
    ''' <summary>
    ''' Public shared method of instantiating MessageHandler.
    ''' </summary>
    ''' <param name="employeeNumber">The employee number of the employee associated with this instance of MessageHandler.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CreateNewHandler(employeeNumber As Integer) As IMessageHandler
        Return New MessageHandler(employeeNumber)
    End Function

#End Region

#Region " get messages "
    ''' <summary>
    ''' Returns a list of all messages for the employee.
    ''' </summary>
    ''' <returns>MessageDisplayCollection</returns>
    Public Overridable Function GetMessages() As MessageDisplayCollection Implements IMessageHandler.GetMessages
        Dim messageList As New MessageDisplayCollection()

        Using ctx As New AdvantageMessaging.Data.MessageDataContext()
            For Each item As MessageDisplay In ctx.MessageEmployees _
                     .Include("MessageSchedule") _
                     .Include("MessageSchedule.Message") _
                     .Where(Function(e) e.EmployeeNo = EmployeeNumber).ToArray() _
                     .Select(Function(z)
                                 Return MessageDisplay.CreateFromModel(z)
                             End Function).ToList()

                messageList.Add(item)

            Next

        End Using

        Return messageList

    End Function

    ''' <summary>
    ''' Returns a list of all new messages for the employee.
    ''' </summary>
    ''' <returns>MessageDisplayCollection</returns>
    Public Overridable Function GetNewMessages() As MessageDisplayCollection Implements IMessageHandler.GetNewMessages
        Dim messageList As New MessageDisplayCollection()

        Using ctx As New AdvantageMessaging.Data.MessageDataContext()
            For Each item As MessageDisplay In ctx.MessageEmployees _
                       .Include("MessageSchedule") _
                       .Include("MessageSchedule.Message") _
                       .Where(Function(e) e.EmployeeNo = EmployeeNumber).ToArray() _
                       .Select(Function(z)
                                   Return MessageDisplay.CreateFromModel(z)
                               End Function).ToList()

                messageList.Add(item)

            Next

        End Using

        Return messageList

    End Function

#End Region

#Region " message state "
    ''' <summary>
    ''' Updated the status of the message to having been read.
    ''' </summary>
    ''' <param name="message">The message to update.</param>
    ''' <returns>The updated IMessageDisplay instance.</returns>
    Public Overridable Function MarkMessageAsRead(message As IMessageDisplay) As IMessageDisplay Implements IMessageHandler.MarkMessageAsRead
        If message Is Nothing Then
            Throw New ArgumentNullException("Invalid message")
        End If

        Dim state As IMessageDisplayState = Nothing
        Dim model As MessageEmployeeModel = Nothing

        model = DbContext.MessageEmployees.FirstOrDefault(Function(m) m.MessageEmployeeId = message.MessageEmployeeId)

        If model Is Nothing Then
            Throw New InvalidOperationException("Could not find this message")
        End If

        model.IsRead = True

        DbContext.SaveChanges()

        state = DirectCast(message, IMessageDisplayState)

        state.MarkRead()

        Return state

    End Function

    ''' <summary>
    ''' Updated the status of the message to having been viewed.
    ''' </summary>
    ''' <param name="message">The message to update.</param>
    ''' <returns>The updated IMessageDisplay instance.</returns>
    Public Overridable Function MarkMessageAsViewed(message As IMessageDisplay) As IMessageDisplay Implements IMessageHandler.MarkMessageAsViewed
        If message Is Nothing Then
            Throw New ArgumentNullException("Invalid message")
        End If

        Dim state As IMessageDisplayState = Nothing
        Dim model As MessageEmployeeModel = Nothing

        model = DbContext.MessageEmployees.FirstOrDefault(Function(m) m.MessageEmployeeId = message.MessageEmployeeId)

        If model Is Nothing Then
            Throw New InvalidOperationException("Could not find this message")
        End If

        model.Viewed = DateTime.Now()

        DbContext.SaveChanges()

        state = DirectCast(message, IMessageDisplayState)

        state.MarkViewed()

        Return state

    End Function

#End Region

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overrides Sub Dispose(disposing As Boolean)

        If Not Me.disposedValue Then
            If disposing Then

            End If
        End If

        MyBase.Dispose(disposing)

        Me.disposedValue = True

    End Sub

#End Region

End Class
