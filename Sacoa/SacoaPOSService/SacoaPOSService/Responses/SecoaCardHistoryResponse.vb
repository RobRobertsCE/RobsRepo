Imports SacoaPOSService.Logic

Namespace Responses

    Public Class SecoaCardHistoryResponse
        Inherits SecoaResponse

        Private Enum Fields
            TotalRecordCount = 2
            RetreivedRecordCount
        End Enum

        Public Property TotalRecordCount As Integer
        Public Property RetreivedRecordCount As Integer
        Public Property CardHistory As List(Of SecoaCardHistory)

        Protected Friend Sub New(responseString As String)
            ParseResponse(responseString)
        End Sub

        Protected Friend Sub New(responseValues As String())
            ParseResponse(responseValues)
        End Sub

        Protected Friend Overrides Sub ParseResponse(responseString As String)
            Dim responseValues As String() = responseString.Split(","c)
            ParseResponse(responseValues)
        End Sub

        Protected Friend Overrides Sub ParseResponse(responseValues As String())
            MyBase.ParseResponse(responseValues)
            TotalRecordCount = CInt(responseValues(Fields.TotalRecordCount))
            RetreivedRecordCount = CInt(responseValues(Fields.RetreivedRecordCount))
            CardHistory = New List(Of SecoaCardHistory)()
            For idx As Integer = Fields.RetreivedRecordCount + 1 To RetreivedRecordCount + Fields.RetreivedRecordCount - 1
                CardHistory.Add(New SecoaCardHistory(responseValues(idx)))
            Next
        End Sub

    End Class

End Namespace