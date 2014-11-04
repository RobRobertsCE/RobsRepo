Namespace Commands

    Public Class SecoaDelayedRechargeCommand
        Inherits SecoaCardCommand

        Public Property HyperCreditType As String
        Public Property AnsiDate As String
        Public Property Time As String

        Public Overrides ReadOnly Property CommandName As String
            Get
                Return "DELAYED RECHARGE"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildCommand() As String
            Return MyBase.FormatCommand(CardRange, Credits, Bonus, Courtesy, Bonus, Status, Minutes, MoneyPaid, CardCharge, OldPassports, HyperCreditType, AnsiDate, Time)
        End Function

    End Class

End Namespace

