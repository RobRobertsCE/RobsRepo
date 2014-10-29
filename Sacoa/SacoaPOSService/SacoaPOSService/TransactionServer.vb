Imports System.Threading
Imports SacoaPOSService.Commands
Imports SacoaPOSService.Responses

Public Delegate Sub SecoaResponseDelegate(e As ISecoaResponse)

Public Class TransactionServer

#Region " Properties "

    Private ReadOnly _port As Integer
    Public ReadOnly Property Port() As Integer
        Get
            Return _port
        End Get
    End Property

    Private ReadOnly _host As String
    Public ReadOnly Property Host() As String
        Get
            Return _host
        End Get
    End Property

#End Region

#Region " Constructor "

    Sub New(port As Integer, host As String)
        _port = port
        _host = host
    End Sub

#End Region

#Region " Public SendCommand/SendCommandAsync "

    Public Sub SendCommandAsync(command As ISecoaCommand, callback As SecoaResponseDelegate)
        Try
            Dim commandThread As New Thread(Sub() RunCommand(command, callback))
            commandThread.Start()
        Catch ex As Exception
            Throw New Exception("Error sending command: " & ex.Message)
        End Try
    End Sub

    Public Function SendCommand(command As ISecoaCommand) As ISecoaResponse
        Try
            Return RunCommand(command)
        Catch ex As Exception
            Throw New Exception("Error sending command: " & ex.Message)
        End Try
    End Function

#End Region

#Region " Private RunCommand "

    Private Sub RunCommand(command As ISecoaCommand, callback As SecoaResponseDelegate)
        Try
            Dim response As ISecoaResponse = Nothing

            Dim data As String = command.BuildCommand()

            'three ways to send command: tcp, file, activex

            callback.Invoke(response)

        Catch ex As Exception
            callback.Invoke(New Responses.SecoaErrorResponse(command, ex.Message))
        End Try
    End Sub

    Private Function RunCommand(command As ISecoaCommand) As ISecoaResponse
        Dim response As ISecoaResponse = Nothing

        Dim data As String = command.BuildCommand()

        'three ways to send command: tcp, file, activex

        Return response
    End Function

#End Region

End Class
