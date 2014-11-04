Imports SacoaPOSService.Commands
Imports SacoaPOSService.Responses
Imports System

Namespace Service

    Public Class ActiveXTransactionServer
        Inherits SecoaTransactionServer
        Implements ISecoaTransactionServer


        Private Class StubActiveXPosServer
            Public Function RefreshPlayCardDb() As Boolean
                Return True
            End Function
            Public Function Process(command As String) As String
                Return command
            End Function
        End Class

#Region " Fields "
        Private _posServer As New StubActiveXPosServer
#End Region

#Region " Constructor "

        Protected Friend Sub New()

        End Sub

#End Region

#Region " GetCommandString "

        Protected Friend Overrides Function GetCommandString(command As ISecoaCommand) As String
            Return command.BuildCommand()
        End Function

#End Region

#Region " SendSecoaCommand "

        Protected Friend Overrides Function SendSecoaCommand(cmd As String) As String
            _posServer.RefreshPlayCardDb()
            Return _posServer.Process(cmd)
        End Function

#End Region

    End Class

End Namespace