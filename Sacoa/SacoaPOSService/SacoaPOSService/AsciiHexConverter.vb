Imports System.Runtime.CompilerServices

Module AsciiHexConverterExtensions

    <Extension()>
    Public Function FromAsciiHex(encodedString As String) As String
        Dim sb As New System.Text.StringBuilder()
        For Each letterInHex As String In Enumerable.Range(0, encodedString.Length \ 2).[Select](Function(i) encodedString.Substring(i * 2, 2))
            sb.Append(ChrW(CInt("&H" & letterInHex)))
        Next
        Return sb.ToString()
    End Function

    <Extension()>
    Public Function ToAsciiHex(stringToEncode As String) As String
        Dim sb As New System.Text.StringBuilder()
        For Each letterToConvert As String In stringToEncode.ToCharArray()
            sb.Append(Conversion.Hex(Asc(letterToConvert)))
        Next
        Return sb.ToString()
    End Function

End Module
