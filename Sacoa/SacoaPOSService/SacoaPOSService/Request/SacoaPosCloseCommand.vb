﻿Namespace Request

    Public Class SacoaPosCloseRequest
        Inherits SacoaRequestBase

        Public Overrides ReadOnly Property RequestName As String
            Get
                Return PosClose
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

    End Class

End Namespace

