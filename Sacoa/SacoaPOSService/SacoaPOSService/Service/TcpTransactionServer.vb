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

                        Dim txData As Byte() = Encoding.UTF8.GetBytes(cmd)
                        networkStream.Write(txData, 0, txData.Length)

                        Dim rxData(client.ReceiveBufferSize) As Byte
                        Dim bufferSize As Integer = client.ReceiveBufferSize

                        'networkStream.ReadTimeout = 5000

                        'While (True)
                        '    Dim bytes = networkStream.Read(rxData, 0, rxData.Length)
                        '    If (bytes = 0) Then
                        '        Exit While
                        '    End If
                        '    Dim temp = System.Text.Encoding.UTF8.GetString(rxData, 0, bytes)
                        '    responseData = responseData + temp
                        'End While

                        ' Examples for CanRead, Read, and DataAvailable. 
                        ' Check to see if this NetworkStream is readable. 
                        If networkStream.CanRead Then
                            Dim myReadBuffer(4096) As Byte
                            Dim myCompleteMessage As StringBuilder = New StringBuilder()
                            Dim numberOfBytesRead As Integer = 0
                            ' Incoming message may be larger than the buffer size. 
                            Do
                                numberOfBytesRead = networkStream.Read(myReadBuffer, 0, myReadBuffer.Length)
                                myCompleteMessage.AppendFormat("{0}", Encoding.ASCII.GetString(myReadBuffer, 0, numberOfBytesRead))
                            Loop While networkStream.DataAvailable
                            ' Print out the received message to the console.
                            Console.WriteLine(("You received the following message : " + myCompleteMessage.ToString()))
                            responseData = myCompleteMessage.ToString().Replace("<EOF>", "")
                        Else
                            Console.WriteLine("Sorry.  You cannot read from this NetworkStream.")
                        End If
                    End Using
                End Using
            End Using
            Return (responseData)
        End Function

#End Region

    End Class

End Namespace