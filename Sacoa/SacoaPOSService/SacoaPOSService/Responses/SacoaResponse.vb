Namespace Responses

    Public MustInherit Class SacoaResponse
        Implements ISacoaResponse

        Private _responseState As String = String.Empty
        Public Overridable ReadOnly Property ResponseState As String Implements ISacoaResponse.ResponseState
            Get
                Return _responseState
            End Get
        End Property

        Protected Friend Sub New()

        End Sub

        Private _responseName As String = String.Empty
        Public Overridable ReadOnly Property ResponseName As String Implements ISacoaResponse.ResponseName
            Get
                Return _responseName
            End Get
        End Property

        Protected Friend Overridable Sub ParseResponse(responseString As String)
            Dim responseValues As String() = responseString.Split(SplitOnComma)
            ParseResponse(responseValues)
        End Sub

        Protected Friend Overridable Sub ParseResponse(responseValues As String())
            _responseState = responseValues(0).Trim()
            _responseName = responseValues(1).Trim()
            If (ResponseState = "ERROR") Then
                Throw New InvalidOperationException(String.Format("{0}: {1}", _responseName, responseValues(2)))
            End If
        End Sub

    End Class

End Namespace
