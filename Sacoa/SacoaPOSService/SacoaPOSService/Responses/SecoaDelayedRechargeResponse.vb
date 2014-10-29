Namespace Responses

    Public Class SecoaDelayedRechargeResponse
        Inherits SecoaResponse

        Public Property RechargeMdbFileName As String

        Protected Friend Overrides Sub ParseResponse(response As String)
            MyBase.ParseResponse(response)

            Dim values As String() = response.Split(","c)

            RechargeMdbFileName = values(2)
        End Sub

    End Class

End Namespace
