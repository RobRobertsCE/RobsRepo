Namespace Request

    Public Class SacoaCardsConsolidateRequest
        Inherits SacoaRequestBase

        Public Property SourceCardCount As Integer
        Public Property TargetCardNumber As String
        Public Property SourceCardNumbers As IList(Of String)

        Public Overrides ReadOnly Property RequestName As String
            Get
                Return CardsConsolidate
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildRequest() As String
            Dim params As New List(Of String)()
            params.Add(SourceCardCount)
            params.Add(TargetCardNumber)
            params.AddRange(SourceCardNumbers)
            Return MyBase.FormatRequest(params)
        End Function

    End Class

End Namespace

