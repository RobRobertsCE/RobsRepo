Imports SacoaService.Logic

Namespace Responses

    Public Class SacoaCardHistoryResponse
        Inherits SacoaResponse

        Private Enum Fields
            TotalRecordCount = 2
            RetreivedRecordCount
        End Enum

        Public Property TotalRecordCount As Integer
        Public Property RetreivedRecordCount As Integer
        Public Property CardHistory As List(Of SacoaCardHistory)

        Public Sub New(responseString As String)
            ParseResponse(responseString)
        End Sub

        Protected Friend Sub New(responseValues As String())
            ParseResponse(responseValues)
        End Sub

        Protected Friend Overrides Sub ParseResponse(responseString As String)
            Dim responseValues As String() = responseString.Split(SplitOnComma)
            ParseResponse(responseValues)
        End Sub

        Protected Friend Overrides Sub ParseResponse(responseValues As String())
            MyBase.ParseResponse(responseValues)
            TotalRecordCount = CInt(responseValues(Fields.TotalRecordCount))
            RetreivedRecordCount = CInt(responseValues(Fields.RetreivedRecordCount))
            CardHistory = New List(Of SacoaCardHistory)()
            Dim startingHistoryRecordIdx As Integer = Fields.RetreivedRecordCount + 1
            For historyRecordIdx As Integer = startingHistoryRecordIdx To responseValues.Count - 1
                CardHistory.Add(New SacoaCardHistory(responseValues(historyRecordIdx)))
            Next
        End Sub

    End Class

End Namespace