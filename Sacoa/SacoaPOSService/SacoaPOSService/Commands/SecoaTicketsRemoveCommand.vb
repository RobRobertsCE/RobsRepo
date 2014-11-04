Namespace Commands

    Public Class SecoaTicketsRemoveCommand
        Inherits SecoaCommand

        Public Property CardRange As String
        Public Property TicketAmount As String

        Public Overrides ReadOnly Property CommandName As String
            Get
                Return "TICKETS RMV"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildCommand() As String
            Return MyBase.FormatCommand(CardRange, TicketAmount)
        End Function

    End Class

End Namespace

