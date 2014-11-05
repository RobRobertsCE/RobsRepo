Imports SacoaService.Response

Public Class SacoaResponseFactory


    Private Enum Fields
        OkError = 0
        ResponseType = 1
    End Enum

    Public Shared Function GetResponse(responseString As String) As ISacoaResponse
        Dim response As ISacoaResponse = Nothing
        Dim responseValues() As String = GetResponseValues(responseString)
        Dim responseType As String = GetResponseType(responseValues)
        Select Case responseType.Trim()
            Case CardData, CardDebit, CardRecharge, CardRefund, CardRoam,
                CardSale, CardSet, CardSetChild, TicketsAdd, TicketsRmv,
                TicketsSetType, CardsConsolidate, SellPromo, CardTransfer
                response = New SacoaCardDataResponse(responseValues)
            Case CardDecode
                response = New SacoaCardDecodeResponse(responseValues)
            Case CardHistory
                response = New SacoaCardHistoryResponse(responseValues)
            Case DelayedRecharge
                response = New SacoaDelayedRechargeResponse(responseValues)
            Case PosOpen, PosClose
                response = New SacoaPosResponse(responseValues)
            Case Version
                response = New SacoaVersionResponse(responseValues)
            Case SupportedCommands
                response = New SacoaSupportedCommandsResponse(responseValues)
            Case Else
                Throw New ArgumentException(responseType)
        End Select
        Return response
    End Function

    Private Shared Function GetResponseValues(responseString As String) As String()
        Return responseString.Split(SplitOnComma)
    End Function

    Private Shared Function GetResponseType(responseValues As String()) As String
        Return responseValues(Fields.ResponseType)
    End Function

End Class
