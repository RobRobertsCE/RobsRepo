Imports AdvantageMessaging.Data
Imports AdvantageMessaging.Logic

Public Class MessageHandler
    Implements IMessageHandler, IDisposable

#Region " fields "
    ''' <summary>
    ''' The employee number of the employee associated with this instance of MessageHandler.
    ''' </summary>
    Private ReadOnly _employeeNumber As Integer = -1

    ''' <summary>
    ''' The DbContext instance used by this instance of MessageHandler.
    ''' </summary>
    Private _dbContext As MessageDataContext = Nothing

    ''' <summary>
    ''' Flag indicating that this instance owns the dbcontext instance.
    ''' </summary>
    ''' <remarks></remarks>
    Private _ownsContext As Boolean = False

#End Region

#Region " properties "
    ''' <summary>
    ''' The DbContext instance used by this instance of MessageHandler.
    ''' </summary>
    Protected Overridable ReadOnly Property DbContext As MessageDataContext
        Get
            If (_dbContext Is Nothing) Then
                _dbContext = New MessageDataContext()
            End If
            Return _dbContext
        End Get
    End Property

#End Region

#Region " ctor "
    ''' <summary>
    ''' Private constructor for MessageHandler.
    ''' </summary>
    ''' <param name="employeeNumber">The employee number of the employee associated with this instance of MessageHandler.</param>
    ''' <remarks>Use the factory method CreateNewHandler for instantiation.</remarks>
    Private Sub New(employeeNumber As Integer)
        _employeeNumber = employeeNumber
    End Sub

    ''' <summary>
    ''' Protected constructor for MessageHandler.
    ''' </summary>
    ''' <param name="employeeNumber">The employee number of the employee associated with this instance of MessageHandler.</param>
    ''' <param name="dbContext">External MessageDataContext to use as the data store.</param>
    ''' <remarks></remarks>
    Protected Sub New(employeeNumber As Integer, dbContext As MessageDataContext)
        Me.New(employeeNumber)
        _dbContext = dbContext
        _ownsContext = False
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
            Dim messages = ctx.MessageSchedules.Include("Message").Where(Function(m) m.EmployeeNo = _employeeNumber).ToArray().Select(Function(m) MessageDisplay.CreateFromModel(m)).OrderBy(Function(m) m.Received).ToList()

            If Not (messages Is Nothing) Then
                messageList.AddRange(messages)
            End If

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
            Dim messages = ctx.MessageSchedules.Include("Message").Where(Function(m) m.EmployeeNo = _employeeNumber And Not m.Viewed.HasValue).ToArray().Select(Function(m) MessageDisplay.CreateFromModel(m)).OrderBy(Function(m) m.Received).ToList()

            If Not (messages Is Nothing) Then
                messageList.AddRange(messages)
            End If

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
        Dim model As MessageScheduleModel = Nothing

        model = DbContext.MessageSchedules.FirstOrDefault(Function(m) m.MessageScheduleId = message.MessageScheduleId And m.EmployeeNo = _employeeNumber)

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
        Dim model As MessageScheduleModel = Nothing

        model = DbContext.MessageSchedules.FirstOrDefault(Function(m) m.MessageScheduleId = message.MessageScheduleId And m.EmployeeNo = _employeeNumber)

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
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                If (_ownsContext) AndAlso Not _dbContext Is Nothing Then
                    _dbContext.Dispose()
                End If

            End If
        End If
        Me.disposedValue = True
    End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
