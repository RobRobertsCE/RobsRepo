Namespace Request

    Public Class SacoaCardReturnItemRequest
        Inherits SacoaCardRequestBase

        Public Property Deposit As String

        'This property not used for this request.
        Public Shadows Property CardCharge As String
            Get
                Throw New NotImplementedException()
            End Get
            Set(value As String)
                Throw New NotImplementedException()
            End Set
        End Property

        Public Overrides ReadOnly Property RequestName As String
            Get
                Return CardReturnItem
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildRequest() As String
            Return MyBase.FormatRequest(CardRange, Credits, Bonus, Courtesy, Status, Minutes, MoneyPaid, Deposit, OldPassports)
        End Function

    End Class

End Namespace

