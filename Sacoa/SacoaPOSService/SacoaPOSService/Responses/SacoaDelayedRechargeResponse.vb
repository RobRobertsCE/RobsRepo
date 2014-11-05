Namespace Responses

    Public Class SacoaDelayedRechargeResponse
        Inherits SacoaResponse

        Private Enum Fields
            RechargeMdbFileName = 2
        End Enum

        Public Property RechargeMdbFileName As String

        Protected Friend Sub New(responseString As String)
            ParseResponse(responseString)
        End Sub

        Protected Friend Sub New(responseValues As String())
            ParseResponse(responseValues)
        End Sub

        Protected Friend Overrides Sub ParseResponse(responseString As String)
            Dim responseValues As String() = responseString.Split(SplitOnComma)
            ParseResponse(responseValues)
        End Sub

        Protected Friend Overrides Sub ParseResponse(responseValues As String())
            MyBase.ParseResponse(responseValues)
            RechargeMdbFileName = responseValues(Fields.RechargeMdbFileName)
        End Sub

    End Class

End Namespace
