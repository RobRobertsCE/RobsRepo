Namespace Logic

    Public Class SecoaVersionDescription
        Public Property VersionName As String
        Public Property VersionList As New List(Of String)
        Public Sub New(versionDescriptionString As String)
            VersionList.AddRange(versionDescriptionString.Split(SplitOnSemiColon))
            VersionName = VersionList(0)
        End Sub
    End Class

End Namespace