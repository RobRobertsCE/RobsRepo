Namespace Request

    Public Class SacoaCardTransferRequest
        Inherits SacoaRequestBase

        Public Property SourceCardNumber As String
        Public Property TargetCardNumber As String

        Public Overrides ReadOnly Property RequestName As String
            Get
                Return "CARD TRANSFER"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildRequest() As String
            Return MyBase.FormatRequest(SourceCardNumber, TargetCardNumber)
        End Function

    End Class

End Namespace

