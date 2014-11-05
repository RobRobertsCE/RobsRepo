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

        Protected Friend Overrides Function SendSecoaCommand(secoaCommand As String) As String
            Dim address = IPAddress.Parse(_host)
            Dim localEndPoint As New IPEndPoint(address, _port)
            Dim responseData = String.Empty
            Dim bufferSize As Integer = 16384

            Using client = New TcpClient()
                client.Connect(localEndPoint)
                client.NoDelay = True

                Using networkStream As NetworkStream = client.GetStream()
                    Using clientStreamWriter As StreamWriter = New StreamWriter(networkStream)
                        '// Send Request 
                        clientStreamWriter.Flush()
                        Dim txData As Byte() = Encoding.UTF8.GetBytes(secoaCommand)
                        networkStream.Write(txData, 0, txData.Length)
                        Thread.Sleep(3000)
                        '// Receive Response 
                        client.ReceiveBufferSize = bufferSize
                        If networkStream.CanRead Then
                            Dim rxData(client.ReceiveBufferSize) As Byte
                            Dim messageBuilder As StringBuilder = New StringBuilder()
                            Dim numberOfBytesRead As Integer = 0
                            Do
                                numberOfBytesRead = networkStream.Read(rxData, 0, rxData.Length)
                                messageBuilder.AppendFormat("{0}", Encoding.ASCII.GetString(rxData, 0, numberOfBytesRead))
                            Loop While networkStream.DataAvailable
                            responseData = messageBuilder.ToString()
                            Console.WriteLine(("Rx : " + responseData))
                        Else
                            Console.WriteLine("Could not read from the NetworkStream.")
                        End If
                    End Using
                End Using
            End Using
            Return responseData
        End Function

#End Region

    End Class

End Namespace