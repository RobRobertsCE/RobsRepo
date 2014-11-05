Namespace Request

    Public Class SacoaCardHistoryRequest
        Inherits SacoaCardNumberRequest

        Private Enum Fields
            CardNumber = 2
            DesiredRecords = 3
        End Enum

        Public Property DesiredRecords As Integer

        Public Overrides ReadOnly Property RequestName As String
            Get
                Return CardHistory
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildRequest() As String
            Return MyBase.FormatRequest(CardNumber, DesiredRecords)
        End Function

    End Class

End Namespace
