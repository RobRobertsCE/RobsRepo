Namespace Response

    Public Class SacoaCardDataResponse
        Inherits SacoaResponseBase

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
            ChildStatus
            TicketType
        End Enum

        Public Property CardRange As String
        Public Property Credits As String
        Public Property Bonus As String
        Public Property Courtesy As String
        Public Property Status As SacoaCardStatus
        Public Property Station As String
        Public Property LastGameId As String
        Public Property CreditsLastBought As String
        Public Property CreditsLastPlayed As String
        Public Property DateLastBought As Date
        Public Property DateLastPlayed As Date
        Public Property TimeLastBought As TimeSpan
        Public Property TimeLastPlayed As TimeSpan
        Public Property ConsecutiveDays As String
        Public Property TotalDays As String
        Public Property TotalBuys As String
        Public Property TotalSwipes As String
        Public Property TotalCreditsBought As String
        Public Property OldPassports As String
        Public Property Tickets As String
        Public Property CreditsEngineCredits As String
        Public Property TotalCreditsPlayed As String
        Public Property ChildStatus As SacoaChildStatus
        Public Property TicketType As SacoaTicketType

        Public Sub New(responseString As String)
            ParseResponse(responseString)
        End Sub

        Protected Friend Sub New(responseValues As String())
            ParseResponse(responseValues)
        End Sub

        Protected Friend Overrides Sub ParseResponse(response As String)
            Dim values As String() = response.Split(SplitOnComma)
            ParseResponse(values)
        End Sub

        Protected Friend Overrides Sub ParseResponse(values As String())
            MyBase.ParseResponse(values)

            CardRange = values(Fields.CardRange)
            Credits = values(Fields.Credits)
            Bonus = values(Fields.Bonus)
            Courtesy = values(Fields.Courtesy)
            Status = values(Fields.Status).ToSacoaCardStatus()
            Station = values(Fields.Station)
            LastGameId = values(Fields.LastGameId)
            CreditsLastBought = values(Fields.CreditsLastBought)
            CreditsLastPlayed = values(Fields.CreditsLastPlayed)
            DateLastBought = values(Fields.DateLastBought).FromSacoaDate()
            DateLastPlayed = values(Fields.DateLastPlayed).FromSacoaDate()
            TimeLastBought = values(Fields.TimeLastBought).FromSacoaTime()
            TimeLastPlayed = values(Fields.TimeLastPlayed).FromSacoaTime()
            ConsecutiveDays = values(Fields.ConsecutiveDays)
            TotalDays = values(Fields.TotalDays)
            TotalBuys = values(Fields.TotalBuys)
            TotalSwipes = values(Fields.TotalSwipes)
            TotalCreditsBought = values(Fields.TotalCreditsBought)
            OldPassports = values(Fields.OldPassports)
            Tickets = values(Fields.Tickets)
            CreditsEngineCredits = values(Fields.CreditsEngineCredits)
            TotalCreditsPlayed = values(Fields.TotalCreditsPlayed)
            ChildStatus = values(Fields.ChildStatus).ToSacoaChildStatus()
            TicketType = values(Fields.TicketType).ToSacoaTicketType()
        End Sub

    End Class

End Namespace
