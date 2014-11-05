Imports SacoaInterface.Response
Imports SacoaInterface.Request

Namespace Service

    Public Interface ISacoaTransactionServer

        ''' <summary>
        ''' Sends an async request to the Sacoa server.
        ''' </summary>
        ''' <param name="request">The Sacoa request to send.</param>
        ''' <param name="callback">The SacoaResponseDelegate that will be called when the Sacoa service responds.</param>
        ''' <remarks></remarks>
        Sub SendRequestAsync(request As ISacoaRequest, callback As SacoaResponseDelegate)

        ''' <summary>
        ''' Sends a request to the Sacoa server.
        ''' </summary>
        ''' <param name="request">The Sacoa request to send.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function SendRequest(request As ISacoaRequest) As ISacoaResponse

    End Interface
End NameSpace