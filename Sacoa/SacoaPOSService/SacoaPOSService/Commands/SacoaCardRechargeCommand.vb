Namespace Commands

    Public Class SacoaCardRechargeCommand
        Inherits SacoaCardCommand

        Public Overrides ReadOnly Property CommandName As String
            Get
                Return "CARD RECHARGE"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildCommand() As String
            Return MyBase.FormatCommand(CardRange, Credits, Bonus, Courtesy, Bonus, Status, Minutes, MoneyPaid, CardCharge, OldPassports)
        End Function

    End Class

End Namespace

