Imports SacoaPOSService.Commands
Imports SacoaPOSService.Responses

Namespace Service


    Public Class SacoaService

#Region " Enumerations "

        Private Enum SecoaServerType
            ActiveX
            File
            Tcp
        End Enum

#End Region

#Region " Fields "

        Private ReadOnly _port As Integer = 0
        Private ReadOnly _host As String = String.Empty
        Private ReadOnly _commandDirectory As String = String.Empty
        Private _serverType As SecoaServerType

#End Region

#Region " Constructor "

        Public Sub New()
            _serverType = SecoaServerType.ActiveX
        End Sub

        Public Sub New(commandDirectory As String)
            _commandDirectory = commandDirectory
            _serverType = SecoaServerType.File
        End Sub

        Public Sub New(port As Integer, host As String)
            _port = port
            _host = host
            _serverType = SecoaServerType.Tcp
        End Sub

#End Region

#Region " SendCommand "

        Public Function SendCommand(command As SecoaCardDataCommand) As SecoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SecoaCardDebitCommand) As SecoaCardDataResponse
            Return Send(command)
        End Function

        Public Function SendCommand(command As SecoaCardDecodeCommand) As SecoaCardDecodeResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SecoaCardHistoryCommand) As SecoaCardHistoryResponse
            Return Send(command)
        End Function

        Public Function SendCommand(command As SecoaCardRechargeCommand) As SecoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SecoaCardRefundCommand) As SecoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SecoaCardRoamCommand) As SecoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SecoaCardSaleCommand) As SecoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SecoaCardsConsolidateCommand) As SecoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SecoaCardSetChildCommand) As SecoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SecoaCardSetCommand) As SecoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SecoaCardTransferCommand) As SecoaCardDataResponse
            Return Send(command)
        End Function

        Public Function SendCommand(command As SecoaDelayedRechargeCommand) As SecoaDelayedRechargeResponse
            Return Send(command)
        End Function

        Public Function SendCommand(command As SecoaPosOpenCommand) As SecoaPosResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SecoaPosCloseCommand) As SecoaPosResponse
            Return Send(command)
        End Function

        Public Function SendCommand(command As SecoaSellPromoCommand) As SecoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SecoaTicketsAddCommand) As SecoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SecoaTicketsRemoveCommand) As SecoaCardDataResponse
            Return Send(command)
        End Function
        Public Function SendCommand(command As SecoaTicketSetTypeCommand) As SecoaCardDataResponse
            Return Send(command)
        End Function

        Public Function SendCommand(command As SecoaSupportedCommandsCommand) As SecoaSupportedCommandsResponse
            Return Send(command)
        End Function

#End Region

#Region " SendCommandAsync "

        Public Sub SendCommandAsync(command As ISecoaCommand, callback As SecoaResponseDelegate)
            Dim server = GetTransactionServer()
            server.SendCommandAsync(command, callback)
        End Sub

#End Region

#Region " GetTransactionServer "

        Protected Friend Overridable Function Send(command As ISecoaCommand) As ISecoaResponse
            Dim server = GetTransactionServer()
            Return server.SendCommand(command)
        End Function

        Protected Friend Overridable Function GetTransactionServer() As ISecoaTransactionServer
            Select Case _serverType
                Case SecoaServerType.ActiveX
                    Return New ActiveXTransactionServer()
                Case SecoaServerType.File
                    Return New FileTransactionServer(_commandDirectory)
                Case SecoaServerType.Tcp
                    Return New TcpTransactionServer(_port, _host)
                Case Else
                    Throw New ArgumentException(_serverType)
            End Select
        End Function

#End Region

    End Class

End Namespace