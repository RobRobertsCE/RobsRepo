Namespace Commands

    Public Class SecoaSellPromoCommand
        Inherits SecoaCardCommand

        Public Property PayModeName As String
        Public Property PayModeId As String
        Public Property ProdQty As String
        Public Property SaleModeId As String
        Public Property Invoice As String

        Public Overrides ReadOnly Property CommandName As String
            Get
                Return "SELL PROMO"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildCommand() As String
            Return MyBase.FormatCommand(CardRange, Credits, Bonus, Courtesy, Bonus, Status, Minutes, MoneyPaid, CardCharge, OldPassports,
                                        PayModeName, PayModeId, ProdQty, SaleModeId, Invoice)
        End Function

    End Class

End Namespace

