Imports SacoaInterface.Logic

Namespace Response

    Public Class SacoaVersionResponse
        Inherits SacoaResponseBase

        Private Enum Fields
            Count = 2
        End Enum

        Public Property Versions As List(Of SacoaVersionDescription)

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
            Versions = New List(Of SacoaVersionDescription)()
            Dim versionCount As Integer = CInt(responseValues(Fields.Count))
            For idx As Integer = Fields.Count + 1 To versionCount + Fields.Count - 1
                Versions.Add(New SacoaVersionDescription(responseValues(idx)))
            Next
        End Sub
    End Class

End Namespace

