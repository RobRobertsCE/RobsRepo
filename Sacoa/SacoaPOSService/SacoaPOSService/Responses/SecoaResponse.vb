Namespace Responses

    Public MustInherit Class SecoaResponse
        Implements ISecoaResponse

        Private _responseState As String = "OK"
        Public Overridable ReadOnly Property ResponseState As String Implements ISecoaResponse.ResponseState
            Get
                Return _responseState
            End Get
        End Property

        Private _responseName As String = "CARD DATA"
        Public Overridable ReadOnly Property ResponseName As String Implements ISecoaResponse.ResponseName
            Get
                Return _responseName
            End Get
        End Property

        Protected Friend Sub ParseResponse(response As String)
            Dim values As String() = response.Split(","c)
            _responseState = values(0)
            _responseName = values(1)
        End Sub

    End Class

End Namespace
