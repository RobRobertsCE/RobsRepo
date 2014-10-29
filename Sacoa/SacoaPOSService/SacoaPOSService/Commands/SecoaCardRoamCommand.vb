Namespace Commands

    Public Class SecoaCardRoamCommand
        Inherits SecoaCardNumberCommand

        Public Overrides ReadOnly Property CommandName As String
            Get
                Return "CARD ROAM"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

    End Class

End Namespace


