Namespace Commands

    Public Class SacoaPosCloseCommand
        Inherits SacoaCommand

        Public Overrides ReadOnly Property CommandName As String
            Get
                Return "POS CLOSE"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

    End Class

End Namespace

