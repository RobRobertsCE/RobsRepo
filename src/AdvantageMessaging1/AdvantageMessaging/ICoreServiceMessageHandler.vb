Public Interface ICoreServiceMessageHandler

    ''' <summary>
    ''' Updated the local list of messages from the remote data store. 
    ''' </summary>
    ''' <remarks></remarks>
    Sub UpdateMessageList()

    ''' <summary>
    ''' Updated the local list of message bodies from the remote data store. 
    ''' </summary>
    ''' <remarks></remarks>
    Sub GetMessageBodies()

    ''' <summary>
    ''' Loads the body of the message
    ''' </summary>
    ''' <param name="messageId">The id of the message to load the body for.</param>
    Function GetMessageBody(messageId As Guid) As String

    ''' <summary>
    ''' Sends the local message stats to the remote data store.
    ''' </summary>
    ''' <remarks></remarks>
    Sub UpdateMessageStats()

    ''' <summary>
    ''' Updates the state of the local messages as they expire.
    ''' </summary>
    ''' <remarks></remarks>
    Sub ProcessExpiredMessages()

End Interface
