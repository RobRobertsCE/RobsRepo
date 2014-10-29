Namespace Responses

Public Class SecoaCardDataResponse
    Inherits SecoaResponse
        Private Enum Fields
            CardRange = 2
            Credits
            Bonus
            Courtesy
            Status
            Station
            LastGameId
            CreditsLastBought
            CreditsLastPlayed
            DateLastBought
            DateLastPlayed
            TimeLastBought
            TimeLastPlayed
            ConsecutiveDays
            TotalDays
            TotalBuys
            TotalSwipes
            TotalCreditsBought
            OldPassports
            Tickets
            CreditsEngineCredits
            TotalCreditsPlayed
        End Enum

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

        Protected Friend Overrides Sub ParseResponse(response As String)
            MyBase.ParseResponse(response)

            Dim values As String() = response.Split(","c)

            CardRange = values(Fields.CardRange)
            Credits = values(Fields.Credits)
            Bonus = values(Fields.Bonus)
            Courtesy = values(Fields.Courtesy)
            Status = values(Fields.Status)
            Station = values(Fields.Station)
            LastGameId = values(Fields.LastGameId)
            CreditsLastBought = values(Fields.CreditsLastBought)
            CreditsLastPlayed = values(Fields.CreditsLastPlayed)
            DateLastBought = values(Fields.DateLastBought)
            DateLastPlayed = values(Fields.DateLastPlayed)
            TimeLastBought = values(Fields.TimeLastBought)
            TimeLastPlayed = values(Fields.TimeLastPlayed)
            ConsecutiveDays = values(Fields.ConsecutiveDays)
            TotalDays = values(Fields.TotalDays)
            TotalBuys = values(Fields.TotalBuys)
            TotalSwipes = values(Fields.TotalSwipes)
            TotalCreditsBought = values(Fields.TotalCreditsBought)
            OldPassports = values(Fields.OldPassports)
            Tickets = values(Fields.Tickets)
            CreditsEngineCredits = values(Fields.CreditsEngineCredits)
            TotalCreditsPlayed = values(Fields.TotalCreditsPlayed)
        End Sub

    End Class

End Namespace
