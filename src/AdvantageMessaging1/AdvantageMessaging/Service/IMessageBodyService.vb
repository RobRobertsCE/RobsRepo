Namespace Service

    Public Interface IMessageBodyService
        Inherits IDisposable

        ''' <summary>
        ''' Gets the message body for the given messageId.
        ''' </summary>
        ''' <param name="messageId">The messageId value to get the message body for.</param>
        Function GetMessageBody(messageId As Guid) As String

    End Interface

End Namespace
