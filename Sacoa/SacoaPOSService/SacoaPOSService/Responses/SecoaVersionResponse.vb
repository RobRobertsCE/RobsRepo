Namespace Responses

    Public Class SecoaVersionResponse
        Inherits SecoaResponse

        Private Enum Fields
            Count = 2
        End Enum

        Public Class VersionDescription
            Public Property VersionName As String
            Public Property VersionList As New List(Of String)
            Public Sub New(versionDescriptionString As String)
                VersionList.AddRange(versionDescriptionString.Split(";"c))
                VersionName = VersionList(0)
            End Sub
        End Class

        Public Property Versions As List(Of VersionDescription)


        Protected Friend Sub New(responseString As String)
            ParseResponse(responseString)
        End Sub

        Protected Friend Sub New(responseValues As String())
            ParseResponse(responseValues)
        End Sub

        Protected Friend Overrides Sub ParseResponse(responseString As String)
            Dim responseValues As String() = responseString.Split(","c)
            ParseResponse(responseValues)
        End Sub

        Protected Friend Overrides Sub ParseResponse(responseValues As String())
            MyBase.ParseResponse(responseValues)
            Versions = New List(Of VersionDescription)()
            Dim versionCount As Integer = CInt(responseValues(Fields.Count))
            For idx As Integer = Fields.Count + 1 To versionCount + Fields.Count - 1
                Versions.Add(New VersionDescription(responseValues(idx)))
            Next
        End Sub
    End Class

End Namespace

