Imports AdvantageMessaging.Service.Models

Namespace Service

    Public Interface IMessageStatsService
        Inherits IDisposable

        ''' <summary>
        ''' Updates the message stats for the given messageScheduleId.
        ''' </summary>
        ''' <param name="requestModel">The MessageStatRequestModel containing the information to update the remote data store with.</param>
        Sub UpdateMessageStats(id As Guid, requestModel As MessageStatRequestModel)

    End Interface

End Namespace