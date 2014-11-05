Namespace Request

    Public Class SacoaSellPromoRequest
        Inherits SacoaCardRequestBase

        Public Property PayModeName As String
        Public Property PayModeId As String
        Public Property ProdQty As String
        Public Property SaleModeId As String
        Public Property Invoice As String

        Public Overrides ReadOnly Property RequestName As String
            Get
                Return SellPromo
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildRequest() As String
            Return MyBase.FormatRequest(CardRange, Credits, Bonus, Courtesy, Bonus, Status, Minutes, MoneyPaid, CardCharge, OldPassports,
                                        PayModeName, PayModeId, ProdQty, SaleModeId, Invoice)
        End Function

    End Class

End Namespace

