Namespace Commands

    Public Class SacoaPosOpenCommand
        Inherits SacoaCommand

        Public Overrides ReadOnly Property CommandName As String
            Get
                Return "POS OPEN"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

    End Class

End Namespace

