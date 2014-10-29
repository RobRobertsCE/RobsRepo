Namespace Responses

    Public Class SecoaPosResponse
        Inherits SecoaResponse

        Public Property Result As String

        Protected Friend Overrides Sub ParseResponse(response As String)
            MyBase.ParseResponse(response)

            Dim values As String() = response.Split(","c)

            Result = values(2)
        End Sub

    End Class

End Namespace
