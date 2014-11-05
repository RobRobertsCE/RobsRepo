Namespace Request

    Public Class SacoaCardSetChildRequest
        Inherits SacoaRequestBase

        Public Property CardRange As String
        Public Property ChildStatus As String

        Public Overrides ReadOnly Property RequestName As String
            Get
                Return CardSetChild
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildRequest() As String
            Return MyBase.FormatRequest(CardRange, ChildStatus)
        End Function

    End Class

End Namespace


