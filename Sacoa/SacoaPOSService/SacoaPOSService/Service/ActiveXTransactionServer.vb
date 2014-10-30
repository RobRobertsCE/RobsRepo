Imports SacoaPOSService.Commands
Imports SacoaPOSService.Responses
Imports System

Namespace Service

    Public Class ActiveXTransactionServer
        Inherits SecoaTransactionServer
        Implements ISecoaTransactionServer


#Region " Properties "

#End Region

#Region " Constructor "

        Protected Friend Sub New()

        End Sub

#End Region

#Region " GetCommandString "

        Protected Friend Overrides Function GetCommandString(command As ISecoaCommand) As String
            Return command.BuildCommand() & Environment.NewLine
        End Function

#End Region

#Region " SendSecoaCommand "

        Protected Friend Overrides Function SendSecoaCommand(cmd As String) As String
            Return "OK, ACTIVEX, OK"
        End Function

#End Region

    End Class

End Namespace