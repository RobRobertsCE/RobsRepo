Namespace Request

    Public Class SacoaCardDebitRequest
        Inherits SacoaCardRequestBase

        Public Property DebitCode As String

        Public Overrides ReadOnly Property RequestName As String
            Get
                Return CardDebit
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildRequest() As String
            Return MyBase.FormatRequest(CardRange, Credits, Bonus, Courtesy, Bonus, Status, Minutes, MoneyPaid, CardCharge, OldPassports, DebitCode)
        End Function

    End Class

End Namespace
