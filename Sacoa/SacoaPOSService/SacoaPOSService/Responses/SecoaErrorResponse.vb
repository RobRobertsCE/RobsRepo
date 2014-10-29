Imports SacoaPOSService.Commands

Namespace Responses

    Public Class SecoaErrorResponse
        Inherits SecoaResponse

        Public Property Message As String
        Public Property Command As ISecoaCommand

        Sub New(command As ISecoaCommand, message As String)
            Me.Message = message
            Me.Command = command
        End Sub

        Public Overrides ReadOnly Property ResponseState As String
            Get
                Return "ERROR"
            End Get
        End Property

        Public Overrides ReadOnly Property ResponseName As String
            Get

            End Get
        End Property
    End Class


End Namespace
