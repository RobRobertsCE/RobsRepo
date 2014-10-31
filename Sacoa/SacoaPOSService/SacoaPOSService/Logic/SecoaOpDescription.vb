Namespace Logic

    Public Class SecoaOpDescription
        Public Property CommandName As String
        Public Property CommandParamList As New List(Of String)
        Public Sub New(commandDescriptionString As String)
            CommandParamList.AddRange(commandDescriptionString.Split(";"c))
            CommandName = CommandParamList(1)
        End Sub
    End Class

End Namespace