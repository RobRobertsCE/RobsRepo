Namespace Request

    Public Interface ISacoaRequest

        ReadOnly Property PosId As String
        ReadOnly Property RequestName As String
        ReadOnly Property EmpId As String

        Function BuildRequest() As String

    End Interface

End Namespace

