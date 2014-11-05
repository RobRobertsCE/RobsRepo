Namespace Request

    Public Class SacoaCardDataRequest
        Inherits SacoaCardNumberRequest

        Public Overrides ReadOnly Property RequestName As String
            Get
                Return CardData
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

    End Class

End Namespace
