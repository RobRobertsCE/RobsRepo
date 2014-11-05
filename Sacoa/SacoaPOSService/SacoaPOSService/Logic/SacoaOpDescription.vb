Namespace Logic

    Public Class SacoaOpDescription
        Public Property RequestName As String
        Public Property OpContainerName As String
        Public Property RequestParamList As New List(Of String)

        Public Sub New(requestDescriptionString As String, opContainerName As String)
            Me.OpContainerName = opContainerName
            RequestParamList.AddRange(requestDescriptionString.Split(SplitOnSemiColon))
            If requestDescriptionString.Count < 1 Then
                Throw New ArgumentException(String.Format(My.Resources.Invalid_Data___0_, requestDescriptionString))
            End If
            RequestName = RequestParamList(1)
        End Sub
    End Class

End Namespace