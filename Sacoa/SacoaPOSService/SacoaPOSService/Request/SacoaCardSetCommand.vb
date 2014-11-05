Namespace Request

    Public Class SacoaCardSetRequest
        Inherits SacoaCardRequestBase

        Public Overrides ReadOnly Property RequestName As String
            Get
                Return "CARD SET"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

    End Class

End Namespace

