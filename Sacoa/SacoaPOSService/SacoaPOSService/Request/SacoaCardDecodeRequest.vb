Namespace Request

    Public Class SacoaCardDecodeRequest
        Inherits SacoaCardNumberRequestBase

        Public Overrides ReadOnly Property RequestName As String
            Get
                Return CardDecode
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

    End Class

End Namespace
