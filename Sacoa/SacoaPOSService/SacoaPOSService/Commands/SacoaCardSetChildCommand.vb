Namespace Commands

    Public Class SacoaCardSetChildCommand
        Inherits SacoaCommand

        Public Property CardRange As String
        Public Property ChildStatus As String

        Public Overrides ReadOnly Property CommandName As String
            Get
                Return "CARD SET CHILD"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildCommand() As String
            Return MyBase.FormatCommand(CardRange, ChildStatus)
        End Function

    End Class

End Namespace


