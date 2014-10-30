Namespace Responses

    Public MustInherit Class SecoaResponse
        Implements ISecoaResponse

        Private _responseState As String = String.Empty
        Public Overridable ReadOnly Property ResponseState As String Implements ISecoaResponse.ResponseState
            Get
                Return _responseState
            End Get
        End Property

        Protected Friend Sub New()

        End Sub

        Private _responseName As String = String.Empty
        Public Overridable ReadOnly Property ResponseName As String Implements ISecoaResponse.ResponseName
            Get
                Return _responseName
            End Get
        End Property

        Protected Friend Overridable Sub ParseResponse(responseString As String)
            Dim responseValues As String() = responseString.Split(","c)
            ParseResponse(responseValues)
        End Sub

        Protected Friend Overridable Sub ParseResponse(responseValues As String())
            _responseState = responseValues(0)
            _responseName = responseValues(1)
        End Sub

    End Class

End Namespace
