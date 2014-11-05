Imports SacoaService.Request
Imports SacoaService.Response

Namespace Service


    Public Class SacoaService

#Region " Enumerations "

        Private Enum SacoaServerType
            File
            Tcp
        End Enum

#End Region

#Region " Fields "

        Private ReadOnly _port As Integer = 0
        Private ReadOnly _host As String = String.Empty
        Private ReadOnly _commandDirectory As String = String.Empty
        Private _serverType As SacoaServerType

#End Region

#Region " Constructor "

        Public Sub New(commandDirectory As String)
            _commandDirectory = commandDirectory
            _serverType = SacoaServerType.File
        End Sub

        Public Sub New(port As Integer, host As String)
            _port = port
            _host = host
            _serverType = SacoaServerType.Tcp
        End Sub

#End Region

#Region " SendRequest "

        Public Function SendRequest(command As SacoaCardDataRequest) As SacoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendRequest(command As SacoaCardDebitRequest) As SacoaCardDataResponse
            Return Send(command)
        End Function

        Public Function SendRequest(command As SacoaCardDecodeRequest) As SacoaCardDecodeResponse
            Return Send(command)
        End Function
        Public Function SendRequest(command As SacoaCardHistoryRequest) As SacoaCardHistoryResponse
            Return Send(command)
        End Function

        Public Function SendRequest(command As SacoaCardRechargeRequest) As SacoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendRequest(command As SacoaCardRefundRequest) As SacoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendRequest(command As SacoaCardRoamRequest) As SacoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendRequest(command As SacoaCardSaleRequest) As SacoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendRequest(command As SacoaCardsConsolidateRequest) As SacoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendRequest(command As SacoaCardSetChildRequest) As SacoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendRequest(command As SacoaCardSetRequest) As SacoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendRequest(command As SacoaCardTransferRequest) As SacoaCardDataResponse
            Return Send(command)
        End Function

        Public Function SendRequest(command As SacoaDelayedRechargeRequest) As SacoaDelayedRechargeResponse
            Return Send(command)
        End Function

        Public Function SendRequest(command As SacoaPosOpenRequest) As SacoaPosResponse
            Return Send(command)
        End Function
        Public Function SendRequest(command As SacoaPosCloseRequest) As SacoaPosResponse
            Return Send(command)
        End Function

        Public Function SendRequest(command As SacoaSellPromoRequest) As SacoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendRequest(command As SacoaTicketsAddRequest) As SacoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendRequest(command As SacoaTicketsRemoveRequest) As SacoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendRequest(command As SacoaTicketSetTypeRequest) As SacoaCardDataResponse
            Return Send(command)
        End Function

        Public Function SendRequest(command As SacoaSupportedCommandsRequest) As SacoaSupportedCommandsResponse
            Return Send(command)
        End Function

#End Region

#Region " SendRequestAsync "

        Public Sub SendRequestAsync(command As ISacoaRequest, callback As SacoaResponseDelegate)
            Try
                GetTransactionServer().SendRequestAsync(command, callback)
            Catch ex As Exception
                'TODO: Error Logging
                Console.WriteLine(ex.ToString())
            End Try
        End Sub

#End Region

#Region " GetTransactionServer "

        Protected Friend Overridable Function Send(command As ISacoaRequest) As ISacoaResponse
            Dim server = GetTransactionServer()
            Return server.SendRequest(command)
        End Function

        Protected Friend Overridable Function GetTransactionServer() As ISacoaTransactionServer
            Select Case _serverType
                Case SacoaServerType.File
                    Return New FileTransactionServer(_commandDirectory)
                Case SacoaServerType.Tcp
                    Return New TcpTransactionServer(_port, _host)
                Case Else
                    Throw New ArgumentException(_serverType)
            End Select
        End Function

#End Region

    End Class

End Namespace