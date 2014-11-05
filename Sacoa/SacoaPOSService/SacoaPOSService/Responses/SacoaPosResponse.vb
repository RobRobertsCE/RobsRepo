Namespace Response

    Public Class SacoaPosResponse
        Inherits SacoaResponse

        Private Enum Fields
            Result = 2
        End Enum

        Public Property Result As String

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
            Result = responseValues(Fields.Result)
        End Sub

    End Class

End Namespace
