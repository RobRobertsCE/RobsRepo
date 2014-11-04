Imports SacoaPOSService.Commands
Imports SacoaPOSService.Responses
Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Namespace Service

    Public Class TcpTransactionServer
        Inherits SecoaTransactionServer
        Implements ISecoaTransactionServer

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

        Protected Friend Sub New(port As Integer, host As String)
            _port = port
            _host = host
        End Sub

#End Region

#Region " GetCommandString "

        Protected Friend Overrides Function GetCommandString(command As ISecoaCommand) As String
            Return command.BuildCommand() & Environment.NewLine
        End Function

#End Region

#Region " SendSecoaCommand "

        Protected Friend Overrides Function SendSecoaCommand(cmd As String) As String
            Dim address = IPAddress.Parse(_host)
            Dim localEndPoint As New IPEndPoint(address, _port)
            Dim responseData = String.Empty

            Using client = New TcpClient()
                client.Connect(localEndPoint)
                client.ReceiveBufferSize = 9990000
                client.NoDelay = True

                Using networkStream As NetworkStream = client.GetStream()
                    Using clientStreamWriter As StreamWriter = New StreamWriter(networkStream)
                        clientStreamWriter.Flush()

                        Dim data As Byte() = Encoding.UTF8.GetBytes(cmd)
                        networkStream.Write(data, 0, data.Length)

                        data(client.ReceiveBufferSize) = New Byte
                        Dim bufferSize As Integer = client.ReceiveBufferSize

                        While (True)
                            Dim bytes = networkStream.Read(data, 0, data.Length)
                            If (bytes = 0) Then
                                Exit While
                            End If
                            Dim temp = System.Text.Encoding.UTF8.GetString(data, 0, bytes)
                            responseData = responseData + temp
                        End While
                        responseData = responseData.Replace("<EOF>", "")

                    End Using
                End Using
            End Using

            Return (responseData)

        End Function

#End Region

    End Class

End Namespace