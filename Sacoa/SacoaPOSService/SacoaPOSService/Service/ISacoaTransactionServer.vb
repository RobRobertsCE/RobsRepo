Imports SacoaPOSService.Commands
Imports SacoaPOSService.Responses

Namespace Service

    Public Interface ISacoaTransactionServer

        Sub SendCommandAsync(command As ISacoaCommand, callback As SacoaResponseDelegate)

        Function SendCommand(command As ISacoaCommand) As ISacoaResponse

    End Interface

End Namespace