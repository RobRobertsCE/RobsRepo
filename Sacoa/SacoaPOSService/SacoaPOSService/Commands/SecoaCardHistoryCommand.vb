Namespace Commands

    Public Class SecoaCardHistoryCommand
        Inherits SecoaCardNumberCommand

        Private Enum Fields
            CardNumber = 2
            DesiredRecords = 3
        End Enum

        Public Property DesiredRecords As Integer

        Public Overrides ReadOnly Property CommandName As String
            Get
                Return "CARD HISTORY"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildCommand() As String
            Return MyBase.FormatCommand(CardNumber, DesiredRecords)
        End Function

    End Class

End Namespace
