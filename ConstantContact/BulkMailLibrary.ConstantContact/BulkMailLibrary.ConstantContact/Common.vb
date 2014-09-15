Public Interface IConstantContactAccountInfo
    Property ApiKey As String
    Property ApplicationName As String
    Property ApiSecret As String
    Property CallPerSecondLimit As Integer
    Property CallPerDayLimit As Integer
    Property AccessToken As String
End Interface

Public Class ConstantContactTestAccountInfo
    Implements IConstantContactAccountInfo
    Public Property ApiKey As String = "94r75x7vuks3y56hcaxeczec" Implements IConstantContactAccountInfo.ApiKey '"6cmwa7rhauy3umjuaw6c73hu"
    Public Property ApplicationName As String = "CEDevelopment" Implements IConstantContactAccountInfo.ApplicationName
    Public Property ApiSecret As String = "QHQh94tNrSUtp2cAgddUkPDS" Implements IConstantContactAccountInfo.ApiSecret
    Public Property CallPerSecondLimit As Integer = 4 Implements IConstantContactAccountInfo.CallPerSecondLimit
    Public Property CallPerDayLimit As Integer = 10000 Implements IConstantContactAccountInfo.CallPerDayLimit
    Public Property AccessToken As String = "4783c1cc-f8a2-4713-84ec-6f46e42380c4" Implements IConstantContactAccountInfo.AccessToken

    Sub New()

    End Sub

End Class
