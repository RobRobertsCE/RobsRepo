﻿Namespace Commands

    Public Class SecoaPosCloseCommand
        Inherits SecoaCommand

        Public Overrides ReadOnly Property CommandName As String
            Get
                Return "POS CLOSE"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

    End Class

End Namespace

