Imports SacoaPOSService.Commands
Imports SacoaPOSService.Responses

Public Class SacoaService

#Region " Fields "

    Private ReadOnly _port As Integer = 0
    Private ReadOnly _host As String = String.Empty

#End Region
  
#Region " Constructor "

    Public Sub New(port As Integer, host As String)
        _port = port
        _host = host
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

#End Region

#Region " SendCommandAsync "

    Public Sub SendCommandAsync(command As ISecoaCommand, callback As SecoaResponseDelegate)
        Dim server = GetTransactionServer()
        server.SendCommandAsync(command, callback)
    End Sub

#End Region

#Region " Helpers "

    Protected Friend Overridable Function Send(command As ISecoaCommand) As ISecoaResponse
        Dim server = GetTransactionServer()
        Return server.SendCommand(command)
    End Function

    Protected Friend Overridable Function GetTransactionServer() As TransactionServer
        Return New TransactionServer(_port, _host)
    End Function

#End Region

End Class

