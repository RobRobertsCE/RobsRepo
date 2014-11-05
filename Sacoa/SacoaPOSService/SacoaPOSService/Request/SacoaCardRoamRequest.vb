Namespace Request

    Public Class SacoaCardRoamRequest
        Inherits SacoaCardNumberRequestBase

        Public Overrides ReadOnly Property RequestName As String
            Get
                Return CardRoam
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

    End Class

End Namespace


