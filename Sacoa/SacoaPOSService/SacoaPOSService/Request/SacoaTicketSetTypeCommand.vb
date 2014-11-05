Namespace Request

    Public Class SacoaTicketSetTypeRequest
        Inherits SacoaRequestBase

        Public Property CardRange As String
        Public Property TicketType As String

        Public Overrides ReadOnly Property RequestName As String
            Get
                Return "TICKETS SET TYPE"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildRequest() As String
            Return MyBase.FormatRequest(CardRange, TicketType)
        End Function

    End Class

End Namespace
