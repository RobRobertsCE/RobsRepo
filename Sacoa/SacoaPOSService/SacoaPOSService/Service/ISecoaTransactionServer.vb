Imports SacoaPOSService.Commands
Imports SacoaPOSService.Responses

Namespace Service

    Public Interface ISecoaTransactionServer

        Sub SendCommandAsync(command As ISecoaCommand, callback As SecoaResponseDelegate)

        Function SendCommand(command As ISecoaCommand) As ISecoaResponse

    End Interface

End Namespace