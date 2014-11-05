Namespace Request

    Public MustInherit Class SacoaCardRequestBase
        Inherits SacoaRequestBase

        Public Property CardRange As String
        Public Property Credits As String
        Public Property Bonus As String
        Public Property Courtesy As String
        Public Property Status As String
        Public Property Minutes As String
        Public Property MoneyPaid As String
        Public Property CardCharge As String
        Public Property OldPassports As String

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildRequest() As String
            Return MyBase.FormatRequest(CardRange, Credits, Bonus, Courtesy, Bonus, Status, Minutes, MoneyPaid, CardCharge, OldPassports)
        End Function

    End Class

End Namespace

