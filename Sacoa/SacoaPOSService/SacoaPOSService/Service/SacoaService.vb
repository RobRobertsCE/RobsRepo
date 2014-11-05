Imports SacoaPOSService.Commands
Imports SacoaPOSService.Responses

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

#Region " SendCommand "

        Public Function SendCommand(command As SacoaCardDataCommand) As SacoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SacoaCardDebitCommand) As SacoaCardDataResponse
            Return Send(command)
        End Function

        Public Function SendCommand(command As SacoaCardDecodeCommand) As SacoaCardDecodeResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SacoaCardHistoryCommand) As SacoaCardHistoryResponse
            Return Send(command)
        End Function

        Public Function SendCommand(command As SacoaCardRechargeCommand) As SacoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SacoaCardRefundCommand) As SacoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SacoaCardRoamCommand) As SacoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SacoaCardSaleCommand) As SacoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SacoaCardsConsolidateCommand) As SacoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SacoaCardSetChildCommand) As SacoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SacoaCardSetCommand) As SacoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SacoaCardTransferCommand) As SacoaCardDataResponse
            Return Send(command)
        End Function

        Public Function SendCommand(command As SacoaDelayedRechargeCommand) As SacoaDelayedRechargeResponse
            Return Send(command)
        End Function

        Public Function SendCommand(command As SacoaPosOpenCommand) As SacoaPosResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SacoaPosCloseCommand) As SacoaPosResponse
            Return Send(command)
        End Function

        Public Function SendCommand(command As SacoaSellPromoCommand) As SacoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SacoaTicketsAddCommand) As SacoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SacoaTicketsRemoveCommand) As SacoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SacoaTicketSetTypeCommand) As SacoaCardDataResponse
            Return Send(command)
        End Function

        Public Function SendCommand(command As SacoaSupportedCommandsCommand) As SacoaSupportedCommandsResponse
            Return Send(command)
        End Function

#End Region

#Region " SendCommandAsync "

        Public Sub SendCommandAsync(command As ISacoaCommand, callback As SacoaResponseDelegate)
            Try
                GetTransactionServer().SendCommandAsync(command, callback)
            Catch ex As Exception
                'TODO: Error Logging
                Console.WriteLine(ex.ToString())
            End Try
        End Sub

#End Region

#Region " GetTransactionServer "

        Protected Friend Overridable Function Send(command As ISacoaCommand) As ISacoaResponse
            Dim server = GetTransactionServer()
            Return server.SendCommand(command)
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