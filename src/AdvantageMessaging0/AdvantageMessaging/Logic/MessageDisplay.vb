Imports AdvantageMessaging.Data

Namespace Logic

    Public Class MessageDisplay
        Implements IMessageDisplay, IMessageDisplayState

#Region " properties "
        ''' <summary>
        ''' The unique Message and Schedule Id.
        ''' </summary>
        Private ReadOnly _messageScheduleId As Guid = Guid.Empty
        Public ReadOnly Property MessageScheduleId As Guid Implements IMessageDisplay.MessageScheduleId
            Get
                Return _messageScheduleId
            End Get
        End Property

        ''' <summary>
        ''' The unique Message Id.
        ''' </summary>
        Private ReadOnly _messageId As Guid = Guid.Empty
        Public ReadOnly Property MessageId As Guid Implements IMessageDisplay.MessageId
            Get
                Return _messageId
            End Get
        End Property

        ''' <summary>
        ''' The subject of the message.
        ''' </summary>
        Private ReadOnly _subject As String = String.Empty
        Public ReadOnly Property Subject As String Implements IMessageDisplay.Subject
            Get
                Return _subject
            End Get
        End Property

        ''' <summary>
        ''' The body of the message.
        ''' </summary>
        Private _body As String = String.Empty
        Public ReadOnly Property Body As String Implements IMessageDisplay.Body
            Get
                Return _body
            End Get
        End Property

        ''' <summary>
        ''' Flag indiciating whether or not the message body has been acquired.
        ''' </summary>
        Public ReadOnly Property HasBody As Boolean Implements IMessageDisplay.HasBody
            Get
                Return Not String.IsNullOrEmpty(_body)
            End Get
        End Property

        ''' <summary>
        ''' Flag indiciating whether or not the message body has been displayed to the user.
        ''' </summary>
        Private _isViewed As Boolean = False
        Public ReadOnly Property IsViewed As Boolean Implements IMessageDisplay.IsViewed
            Get
                Return _isViewed
            End Get
        End Property

        ''' <summary>
        ''' Flag indiciating whether or not the message status has been updated to read.
        ''' </summary>
        Private _isRead As Boolean = False
        Public ReadOnly Property IsRead As Boolean Implements IMessageDisplay.IsRead
            Get
                Return _isRead
            End Get
        End Property

        ''' <summary>
        ''' The timestamp that the message was received by the local system.
        ''' </summary>
        Private ReadOnly _received As DateTime = DateTime.MinValue
        Public ReadOnly Property Received As DateTime Implements IMessageDisplay.Received
            Get
                Return _received
            End Get
        End Property

#End Region

#Region " ctor "
        ''' <summary>
        ''' Default constructor for MessageDisplay.
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()

        End Sub

        ''' <summary>
        ''' Constructor for MessageDisplay.
        ''' </summary>
        ''' <param name="messageScheduleId">The unique Message and Schedule Id.</param>
        ''' <param name="messageId">The unique Message Id.</param>
        ''' <param name="subject">The subject of the message.</param>
        ''' <param name="body">The body of the message.</param>
        ''' <param name="received">The timestamp that the message was received by the local system.</param>
        ''' <remarks></remarks>
        Public Sub New(messageScheduleId As Guid, messageId As Guid, subject As String, body As String, received As DateTime)
            If Guid.Empty.Equals(messageScheduleId) Then
                Throw New ArgumentException("messageScheduleId")
            End If

            If Guid.Empty.Equals(messageId) Then
                Throw New ArgumentException("messageId")
            End If

            If String.Empty.Equals(subject) Then
                Throw New ArgumentException("subject")
            End If

            If DateTime.MinValue.Equals(received) Then
                Throw New ArgumentException("received")
            End If

            _messageScheduleId = messageScheduleId
            _messageId = messageId
            _subject = subject
            _body = body
            _received = received

        End Sub

#End Region

#Region " factory "
        ''' <summary>
        ''' Factory method for creating an instance of MessageDisplay from a MessageScheduleModel.
        ''' </summary>
        ''' <param name="model">The MessageScheduleModel instance to base this MessageDisplay from.</param>
        Public Shared Function CreateFromModel(model As MessageScheduleModel) As MessageDisplay
            If (model Is Nothing) Then
                Throw New ArgumentNullException("model")
            End If

            Return New MessageDisplay(model.MessageScheduleId, model.MessageId, model.Message.Subject, model.Message.Body, model.Received)
        End Function

#End Region

#Region " IMessageDisplayState implementation "
        ''' <summary>
        ''' Updates the IsRead property of this instance.
        ''' </summary>
        ''' <remarks>Only accessible from MessageHandler.</remarks>
        Private Sub MarkRead() Implements IMessageDisplayState.MarkRead
            _isRead = True
        End Sub

        ''' <summary>
        ''' Updates the IsViewed property of this instance.
        ''' </summary>
        ''' <remarks>Only accessible from MessageHandler.</remarks>
        Private Sub MarkViewed() Implements IMessageDisplayState.MarkViewed
            _isViewed = True
        End Sub

        ''' <summary>
        ''' Updates the Body property of this instance.
        ''' </summary>
        ''' <remarks>Only accessible from MessageDisplayCollection.</remarks>
        Private Sub SetBody(body As String) Implements IMessageDisplayState.SetBody
            _body = body
        End Sub

#End Region

    End Class

End Namespace