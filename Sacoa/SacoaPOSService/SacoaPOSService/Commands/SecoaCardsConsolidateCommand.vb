Namespace Commands

    Public Class SecoaCardsConsolidateCommand
        Inherits SecoaCommand

        Public Property SourceCardCount As String
        Public Property TargetCardNumber As String
        Public Property SourceCardNumbers As IList(Of String)

        Public Overrides ReadOnly Property CommandName As String
            Get
                Return "CARDS CONSOLIDATE"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildCommand() As String
            Dim params As New List(Of String)()
            params.Add(SourceCardCount)
            params.Add(TargetCardNumber)
            params.AddRange(SourceCardNumbers)
            Return MyBase.FormatCommand(params)
        End Function

    End Class

End Namespace

