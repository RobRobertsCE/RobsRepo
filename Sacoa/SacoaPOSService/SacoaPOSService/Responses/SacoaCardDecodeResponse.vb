Namespace Response

    Public Class SacoaCardDecodeResponse
        Inherits SacoaResponseBase

        Private Enum Fields
            CardNumber = 2
        End Enum

        Public Property CardNumber As String

        Public Sub New(responseString As String)
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
            CardNumber = responseValues(Fields.CardNumber)
        End Sub

    End Class

End Namespace
