Imports SacoaPOSService.Commands
Imports SacoaPOSService.Responses

Namespace Service

    Public Interface ISecoaTransactionServer

        Sub SendCommandAsync(command As ISecoaCommand, callback As SacoaResponseDelegate)

        Function SendCommand(command As ISecoaCommand) As ISacoaResponse

    End Interface

End Namespace