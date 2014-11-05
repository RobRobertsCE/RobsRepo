Namespace Commands

    Public Class SacoaCardTransferCommand
        Inherits SacoaCommand

        Public Property SourceCardNumber As String
        Public Property TargetCardNumber As String

        Public Overrides ReadOnly Property CommandName As String
            Get
                Return "CARD TRANSFER"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

        Public Overrides Function BuildCommand() As String
            Return MyBase.FormatCommand(SourceCardNumber, TargetCardNumber)
        End Function

    End Class

End Namespace

