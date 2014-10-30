Imports SacoaPOSService.Commands
Imports SacoaPOSService.Responses
Imports System
Imports System.IO
Imports System.Text

Namespace Service

    Public Class FileTransactionServer
        Inherits SecoaTransactionServer
        Implements ISecoaTransactionServer

#Region " Properties "

        Private ReadOnly _secoaCommandDirectory As String
        Public ReadOnly Property SecoaCommandDirectory() As String
            Get
                Return _secoaCommandDirectory
            End Get
        End Property

#End Region

#Region " Constructor "

        Protected Friend Sub New(commandDirectory As String)
            _secoaCommandDirectory = commandDirectory
        End Sub

#End Region

#Region " GetCommandString "

        Protected Friend Overrides Function GetCommandString(command As ISecoaCommand) As String
            Return command.BuildCommand() & Environment.NewLine
        End Function

#End Region

#Region " SendSecoaCommand "

        Protected Friend Overrides Function SendSecoaCommand(cmd As String) As String
            Return "OK, FILE, OK"
        End Function

#End Region

    End Class

End Namespace