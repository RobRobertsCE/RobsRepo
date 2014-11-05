Namespace Commands

    Public Class SacoaTicketSetTypeCommand
        Inherits SacoaCommand

        Public Property CardRange As String
        Public Property TicketType As String

        Public Overrides ReadOnly Property CommandName As String
            Get
                Return "TICKETS SET TYPE"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildCommand() As String
            Return MyBase.FormatCommand(CardRange, TicketType)
        End Function

    End Class

End Namespace
