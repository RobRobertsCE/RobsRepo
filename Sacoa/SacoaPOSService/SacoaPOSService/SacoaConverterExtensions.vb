Imports System.Globalization
Imports System.Runtime.CompilerServices

Module SacoaConverterExtensions

    Private Const SacoaDateTimeFormat As String = "yyyyMMddHHmmss"
    Private Const SacoaDateFormat As String = "yyMMdd"
    Private Const SacoaTimeFormat As String = "HHmmss"

    <Extension()>
    Public Function FromSacoaDateTime(encodedDateTimeString As String) As DateTime
        Return Date.ParseExact(encodedDateTimeString.Trim(), SacoaDateTimeFormat, DateTimeFormatInfo.InvariantInfo)
    End Function
    <Extension()>
    Public Function ToSacoaDateTime(dateTimeToEncode As DateTime) As String
        Return dateTimeToEncode.ToString(SacoaDateTimeFormat, DateTimeFormatInfo.InvariantInfo)
    End Function

    <Extension()>
    Public Function FromSacoaDate(encodedDateString As String) As Date
        Return Date.ParseExact(encodedDateString.Trim(), SacoaDateFormat, DateTimeFormatInfo.InvariantInfo)
    End Function
    <Extension()>
    Public Function ToSacoaDate(dateToEncode As Date) As String
        Return dateToEncode.ToString(SacoaDateTimeFormat, DateTimeFormatInfo.InvariantInfo)
    End Function

    <Extension()>
    Public Function FromSacoaTime(encodedTimeString As String) As TimeSpan
        Return Date.ParseExact(encodedTimeString.Trim(), SacoaTimeFormat, DateTimeFormatInfo.InvariantInfo).TimeOfDay
    End Function
    <Extension()>
    Public Function ToSacoaTime(timeToEncode As TimeSpan) As String
        Return timeToEncode.ToString(SacoaTimeFormat, DateTimeFormatInfo.InvariantInfo)
    End Function

    <Extension()>
    Public Function FromAsciiHex(encodedString As String) As String
        Dim trimmedString = encodedString.Trim()
        Dim sb As New System.Text.StringBuilder()
        For Each letterInHex As String In Enumerable.Range(0, trimmedString.Length \ 2).[Select](Function(i) trimmedString.Substring(i * 2, 2))
            sb.Append(ChrW(CInt("&H" & letterInHex)))
        Next
        Return sb.ToString()
    End Function
    <Extension()>
    Public Function ToAsciiHex(stringToEncode As String) As String
        Dim sb As New System.Text.StringBuilder()
        For Each letterToConvert As String In stringToEncode.Trim().ToCharArray()
            sb.Append(Conversion.Hex(Asc(letterToConvert)))
        Next
        Return sb.ToString()
    End Function

    <Extension()>
    Public Function ToSacoaCardStatus(status As String) As SacoaCardStatus
        Dim returnValue As SacoaCardStatus
        Select Case status.Trim()
            Case "I", "i"
                returnValue = SacoaCardStatus.InHouse
            Case "t"
                returnValue = SacoaCardStatus.NewTimeCard
            Case "T"
                returnValue = SacoaCardStatus.ActiveTimeCard
            Case "o", "O"
                returnValue = SacoaCardStatus.Normal
            Case "v", "V"
                returnValue = SacoaCardStatus.VIP
            Case "s", "S"
                returnValue = SacoaCardStatus.Service
            Case "x", "X"
                returnValue = SacoaCardStatus.LeaveAsIs
            Case Else
                returnValue = SacoaCardStatus.Unknown
        End Select
        Return returnValue
    End Function
    <Extension()>
    Public Function FromSacoaCardStatus(cardStatus As SacoaCardStatus) As String
        Dim returnValue As String
        Select Case cardStatus
            Case SacoaCardStatus.InHouse
                returnValue = "I"
            Case SacoaCardStatus.NewTimeCard
                returnValue = "t"
            Case SacoaCardStatus.ActiveTimeCard
                returnValue = "T"
            Case SacoaCardStatus.Normal
                returnValue = "O"
            Case SacoaCardStatus.VIP
                returnValue = "V"
            Case SacoaCardStatus.Service
                returnValue = "S"
            Case SacoaCardStatus.LeaveAsIs
                returnValue = "X"
            Case Else
                returnValue = "UNKNOWN CARD STATUS: " & cardStatus.ToString()
        End Select
        Return returnValue
    End Function

    <Extension()>
    Public Function ToSacoaTicketType(ticketType As String) As SacoaTicketType
        Dim returnValue As SacoaTicketType
        Select Case ticketType.Trim()
            Case "r", "R"
                returnValue = SacoaTicketType.Real
            Case "v", "V"
                returnValue = SacoaTicketType.Virtual
            Case Else
                returnValue = SacoaTicketType.Unknown
        End Select
        Return returnValue
    End Function
    <Extension()>
    Public Function FromSacoaTicketType(ticketType As SacoaTicketType) As String
        Dim returnValue As String
        Select Case ticketType
            Case SacoaTicketType.Real
                returnValue = "R"
            Case SacoaTicketType.Virtual
                returnValue = "V"
            Case Else
                returnValue = "UNKNOWN TICKET TYPE: " & ticketType.ToString()
        End Select
        Return returnValue
    End Function

    <Extension()>
    Public Function ToSacoaChildStatus(status As String) As SacoaChildStatus
        Return [Enum].Parse(GetType(SacoaChildStatus), status)
    End Function
    <Extension()>
    Public Function FromSacoaChildStatus(status As SacoaChildStatus) As String
        Return status.ToString()
    End Function

    <Extension()>
    Public Function ToSacoaOpType(opType As String) As SacoaOpType
        Dim o As SacoaOpType
        Try
            o = [Enum].Parse(GetType(SacoaOpType), opType)
        Catch ex As Exception
            Console.WriteLine("New OpType: " & opType.ToString())
        End Try
        Return o


    End Function
    <Extension()>
    Public Function FromSacoaOpType(opType As SacoaChildStatus) As String
        Return opType.ToString()
    End Function

End Module
