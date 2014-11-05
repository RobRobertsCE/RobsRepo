Namespace Request

    Public Class SacoaTicketsRemoveRequest
        Inherits SacoaRequestBase

        Public Property CardRange As String
        Public Property TicketAmount As String

        Public Overrides ReadOnly Property RequestName As String
            Get
                Return TicketsRmv
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildRequest() As String
            Return MyBase.FormatRequest(CardRange, TicketAmount)
        End Function

    End Class

End Namespace

