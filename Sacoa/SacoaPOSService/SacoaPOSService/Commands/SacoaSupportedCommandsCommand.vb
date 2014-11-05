Namespace Commands

    Public Class SacoaSupportedCommandsCommand
        Inherits SacoaCommand

        Public Property IncludeHandlerInfo As String = "Yes"

        Public Overrides ReadOnly Property CommandName As String
            Get
                Return "SUPPORTED COMMANDS"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildCommand() As String
            Return MyBase.FormatCommand(IncludeHandlerInfo)
        End Function

    End Class

End Namespace