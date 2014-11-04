Namespace Commands
    Public MustInherit Class SecoaCardNumberCommand
        Inherits SecoaCommand

        Public Property CardNumber As String

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildCommand() As String
            Return MyBase.FormatCommand(CardNumber)
        End Function

    End Class
End Namespace

