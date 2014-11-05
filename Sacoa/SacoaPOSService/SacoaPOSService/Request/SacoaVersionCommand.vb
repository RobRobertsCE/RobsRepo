﻿Namespace Request

    Public Class SacoaVersionRequest
        Inherits SacoaRequestBase

        Public Overrides ReadOnly Property RequestName As String
            Get
                Return "VERSION"
            End Get
        End Property

        Public Sub New(posId As String, empId As String)
            MyBase.New(posId, empId)
        End Sub

    End Class

End Namespace

