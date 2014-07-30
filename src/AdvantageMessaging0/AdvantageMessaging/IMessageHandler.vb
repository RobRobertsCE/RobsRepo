Imports AdvantageMessaging.Logic

Public Interface IMessageHandler
    Inherits IDisposable

    ''' <summary>
    ''' Returns a list of all messages for the employee.
    ''' </summary>
    ''' <returns>MessageDisplayCollection</returns>
    Function GetMessages() As MessageDisplayCollection

    ''' <summary>
    ''' Returns a list of all new messages for the employee.
    ''' </summary>
    ''' <returns>MessageDisplayCollection</returns>
    Function GetNewMessages() As MessageDisplayCollection

    ''' <summary>
    ''' Updated the status of the message to having been read.
    ''' </summary>
    ''' <param name="message">The message to update.</param>
    ''' <returns>The updated IMessageDisplay instance.</returns>
    Function MarkMessageAsRead(message As IMessageDisplay) As IMessageDisplay

    ''' <summary>
    ''' Updated the status of the message to having been viewed.
    ''' </summary>
    ''' <param name="message">The message to update.</param>
    ''' <returns>The updated IMessageDisplay instance.</returns>
    Function MarkMessageAsViewed(message As IMessageDisplay) As IMessageDisplay

End Interface
