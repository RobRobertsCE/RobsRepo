Namespace Request

    Public Class SacoaCardRechargeRequest
        Inherits SacoaCardRequestBase

        Public Overrides ReadOnly Property RequestName As String
            Get
                Return "CARD RECHARGE"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildRequest() As String
            Return MyBase.FormatRequest(CardRange, Credits, Bonus, Courtesy, Bonus, Status, Minutes, MoneyPaid, CardCharge, OldPassports)
        End Function

    End Class

End Namespace

