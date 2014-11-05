Imports SacoaPOSService.Responses

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
            Case "CARD DATA", "CARD DEBIT", "CARD RECHARGE", "CARD REFUND", "CARD ROAM",
                "CARD SALE", "CARD SET", "CARD SET CHILD", "TICKETS ADD", "TICKETS RMV",
                "TICKETS SET TYPE", "CARDS CONSOLIDATE", "SELL PROMO", "CARD TRANSFER"
                response = New SacoaCardDataResponse(responseValues)
            Case "CARD DECODE"
                response = New SacoaCardDecodeResponse(responseValues)
            Case "CARD HISTORY"
                response = New SacoaCardHistoryResponse(responseValues)
            Case "DELAYED RECHARGE"
                response = New SacoaDelayedRechargeResponse(responseValues)
            Case "POS OPEN", "POS CLOSE"
                response = New SacoaPosResponse(responseValues)
            Case "VERSION"
                response = New SacoaVersionResponse(responseValues)
            Case "SUPPORTED COMMANDS"
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
