Namespace Responses

Public Class SecoaCardDataResponse
    Inherits SecoaResponse

        Public Property CardRange As String
        Public Property Credits As String
        Public Property Bonus As String
        Public Property Courtesy As String
        Public Property Status As String
        Public Property Station As String
        Public Property LastGameId As String
        Public Property CreditsLastBought As String
        Public Property CreditsLastPlayed As String
        Public Property DateLastBought As String
        Public Property DateLastPlayed As String
        Public Property TimeLastBought As String
        Public Property TimeLastPlayed As String
        Public Property ConsecutiveDays As String
        Public Property TotalDays As String
        Public Property TotalBuys As String
        Public Property TotalSwipes As String
        Public Property TotalCreditsBought As String
        Public Property OldPassports As String
        Public Property Tickets As String
        Public Property CreditsEngineCredits As String
        Public Property TotalCreditsPlayed As String

        Private _responseName As String = "CARD DATA"
        Public Overrides ReadOnly Property ResponseName As String
            Get
                Return _responseName
            End Get
        End Property

    End Class

End Namespace
