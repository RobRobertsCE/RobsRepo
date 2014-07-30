Namespace Service.Exceptions

    Public Class MessageServiceException
        Inherits Exception

        Sub New()
            MyBase.New("Message API Service Exception")
        End Sub

        Sub New(message As String)
            MyBase.New(message)
        End Sub

        Sub New(message As String, innerException As Exception)
            MyBase.New(message, innerException)
        End Sub
    End Class

End Namespace