Namespace Commands

    Public Class SacoaVersionCommand
        Inherits SacoaCommand

        Public Overrides ReadOnly Property CommandName As String
            Get
                Return "VERSION"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

    End Class

End Namespace


