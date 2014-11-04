Namespace Commands

    Public Class SecoaPosOpenCommand
        Inherits SecoaCommand

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

