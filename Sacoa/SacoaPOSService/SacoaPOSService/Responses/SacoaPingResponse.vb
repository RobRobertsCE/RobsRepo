Namespace Response

    Public Class SacoaPingResponse
        Inherits SacoaResponseBase

        Private Enum Fields
            Result = 2
            TimeoutSeconds
        End Enum

        Public Property Result As String
        Public Property TimeoutSeconds As String

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
            TimeoutSeconds = responseValues(Fields.TimeoutSeconds)
        End Sub

    End Class
  
End Namespace