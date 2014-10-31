Imports SacoaPOSService.Responses

Public Class SecoaResponseFactory

    Private Enum Fields
        OkError = 0
        ResponseType = 1
    End Enum

    Public Shared Function GetResponse(responseString As String) As ISecoaResponse
        Dim response As ISecoaResponse = Nothing
        Dim responseValues() As String = GetResponseValues(responseString)
        Dim responseType As String = GetResponseType(responseValues)
        Select Case responseType
            Case "CARD DATA"
                response = New SecoaCardDataResponse(responseValues)
            Case "CARD DECODE"
                response = New SecoaCardDecodeResponse(responseValues)
            Case "CARD HISTORY"
                response = New SecoaCardHistoryResponse(responseValues)
            Case "DELAYED RECHARGE"
                response = New SecoaDelayedRechargeResponse(responseValues)
            Case "POS OPEN", "POS CLOSE"
                response = New SecoaPosResponse(responseValues)
            Case "VERSION"
                response = New SecoaVersionResponse(responseValues)
            Case "SUPPORTED COMMANDS"
                response = New SecoaSupportedCommandsResponse(responseValues)
            Case Else
                Throw New ArgumentException(responseType)
        End Select
        Return response
    End Function

    Private Shared Function GetResponseValues(responseString As String) As String()
        Return responseString.Split(","c)
    End Function

    Private Shared Function GetResponseType(responseValues As String()) As String
        Return responseValues(Fields.ResponseType)
    End Function

End Class
