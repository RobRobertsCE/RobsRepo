Namespace Responses

    Public Class SecoaCardDecodeResponse
        Inherits SecoaResponse

        Public Property CardNumber As String

        Protected Friend Overrides Sub ParseResponse(response As String)
            MyBase.ParseResponse(response)

            Dim values As String() = response.Split(","c)

            CardNumber = values(2)
        End Sub

    End Class

End Namespace
