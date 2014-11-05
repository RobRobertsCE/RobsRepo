Namespace Request

    Public Class SacoaSupportedCommandsRequest
        Inherits SacoaRequestBase

        Public Property IncludeHandlerInfo As String = "Yes"

        Public Overrides ReadOnly Property RequestName As String
            Get
                Return "SUPPORTED COMMANDS"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildRequest() As String
            Return MyBase.FormatRequest(IncludeHandlerInfo)
        End Function

    End Class

End Namespace