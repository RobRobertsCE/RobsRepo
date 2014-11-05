Imports SacoaService.Request
Imports SacoaService.Response

Namespace Service

    Public Interface ISacoaTransactionServer

        Sub SendRequestAsync(command As ISacoaRequest, callback As SacoaResponseDelegate)

        Function SendRequest(command As ISacoaRequest) As ISacoaResponse

    End Interface

End Namespace