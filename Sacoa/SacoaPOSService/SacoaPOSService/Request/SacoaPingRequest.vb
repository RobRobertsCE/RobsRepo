Namespace Request

    Public Class SacoaPingRequest
        Inherits SacoaCardRequestBase

        Public Property TimeOutSeconds As Integer
        
        Public Overrides ReadOnly Property RequestName As String
            Get
                Return Ping
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildRequest() As String
            Return MyBase.FormatRequest(TimeOutSeconds)
        End Function

    End Class

End Namespace

