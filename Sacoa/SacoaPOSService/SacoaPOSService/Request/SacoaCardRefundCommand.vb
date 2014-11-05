﻿Namespace Request

    Public Class SacoaCardRefundRequest
        Inherits SacoaCardRequestBase

        Public Overrides ReadOnly Property RequestName As String
            Get
                Return CardRefund
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

    End Class

End Namespace

