Namespace Request

    Public Class SacoaDelayedRechargeRequest
        Inherits SacoaCardRequestBase

        Public Property HyperCreditType As String
        Public Property AnsiDate As String
        Public Property Time As String

        Public Overrides ReadOnly Property RequestName As String
            Get
                Return DelayedRecharge
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildRequest() As String
            Return MyBase.FormatRequest(CardRange, Credits, Bonus, Courtesy, Bonus, Status, Minutes, MoneyPaid, CardCharge, OldPassports, HyperCreditType, AnsiDate, Time)
        End Function

    End Class

End Namespace

