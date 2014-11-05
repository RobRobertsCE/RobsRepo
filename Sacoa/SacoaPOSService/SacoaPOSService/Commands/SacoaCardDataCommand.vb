Namespace Commands

    Public Class SacoaCardDataCommand
        Inherits SacoaCardNumberCommand

        Public Overrides ReadOnly Property CommandName As String
            Get
                Return "CARD DATA"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

    End Class

End Namespace
