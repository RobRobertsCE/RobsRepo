Namespace Logic

    Public Class SacoaOpDescription
        Public Property RequestName As String
        Public Property OpContainerName As String
        Public Property RequestParamList As New List(Of String)

        Public Sub New(RequestDescriptionString As String, opContainerName As String)
            Me.OpContainerName = opContainerName
            RequestParamList.AddRange(RequestDescriptionString.Split(SplitOnSemiColon))
            RequestName = RequestParamList(1)
        End Sub
    End Class

End Namespace