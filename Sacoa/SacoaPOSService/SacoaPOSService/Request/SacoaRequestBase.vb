Imports System.Text

Namespace Request

    Public MustInherit Class SacoaRequestBase
        Implements ISacoaRequest

#Region " Properties "

        Private ReadOnly _posId As String = String.Empty
        Public ReadOnly Property PosId As String Implements ISacoaRequest.PosId
            Get
                Return _posId
            End Get
        End Property

        Private ReadOnly _empId As String = String.Empty
        Public ReadOnly Property EmpId As String Implements ISacoaRequest.EmpId
            Get
                Return _empId
            End Get
        End Property

        Public MustOverride ReadOnly Property RequestName As String Implements ISacoaRequest.RequestName

#End Region

#Region " Constructor "

        Protected Friend Sub New(posId As String, empId As String)
            _posId = posId
            _empId = empId
        End Sub

#End Region

#Region " Public Methods "

        Public Overridable Function BuildRequest() As String Implements ISacoaRequest.BuildRequest
            Return FormatRequest()
        End Function

#End Region

#Region " Protected Methods "

        Protected Friend Overridable Function FormatRequest(ParamArray requestData()) As String
            Dim sb As New StringBuilder()
            sb.AppendFormat("{0}, {1}, ", PosId, RequestName)
            For Each item As String In requestData
                sb.AppendFormat("{0}, ", item)
            Next
            sb.AppendFormat("{0}", EmpId)
            Return sb.ToString()
        End Function

#End Region

    End Class

End Namespace
