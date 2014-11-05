Namespace Commands

    Public Class SacoaCardRefundCommand
        Inherits SacoaCardCommand

        Public Overrides ReadOnly Property CommandName As String
            Get
                Return "CARD REFUND"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

    End Class

End Namespace

