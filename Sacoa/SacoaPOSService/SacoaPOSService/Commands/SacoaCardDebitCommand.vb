Namespace Commands

    Public Class SacoaCardDebitCommand
        Inherits SacoaCardCommand

        Public Property DebitCode As String

        Public Overrides ReadOnly Property CommandName As String
            Get
                Return "CARD DEBIT"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildCommand() As String
            Return MyBase.FormatCommand(CardRange, Credits, Bonus, Courtesy, Bonus, Status, Minutes, MoneyPaid, CardCharge, OldPassports, DebitCode)
        End Function

    End Class

End Namespace
