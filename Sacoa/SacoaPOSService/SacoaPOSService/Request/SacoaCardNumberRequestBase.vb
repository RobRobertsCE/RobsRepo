Namespace Request
    Public MustInherit Class SacoaCardNumberRequestBase
        Inherits SacoaRequestBase

        Public Property CardNumber As String

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildRequest() As String
            Return MyBase.FormatRequest(CardNumber)
        End Function

    End Class
End Namespace

