Imports AdvantageMessaging.Service.Models

Namespace Service

    Public Interface IMessageService
        Inherits IDisposable

        ''' <summary>
        ''' Returns a list of messages for the given location.
        ''' </summary>
        ''' <param name="locationHash">A unique hash identifying the location.</param>
        Function GetMessages(locationHash As String) As IList(Of MessageListResponseModel)

    End Interface

End Namespace

