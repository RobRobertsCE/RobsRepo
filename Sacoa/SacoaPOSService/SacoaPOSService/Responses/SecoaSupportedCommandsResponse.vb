Namespace Responses

    Public Class SecoaSupportedCommandsResponse
        Inherits SecoaResponse

        Public Class CommandDescription
            Public Property CommandName As String
            Public Property CommandParamList As New List(Of String)
            Public Sub New(commandDescriptionString As String)
                CommandParamList.AddRange(commandDescriptionString.Split(";"c))
                CommandName = CommandParamList(1)
            End Sub
        End Class

        Private Enum Fields
            Count = 2
        End Enum

        Public Property CommandDescriptions As List(Of CommandDescription)

        Protected Friend Sub New(responseString As String)
            ParseResponse(responseString)
        End Sub

        Protected Friend Sub New(responseValues As String())
            ParseResponse(responseValues)
        End Sub

        Protected Friend Overrides Sub ParseResponse(responseString As String)
            Dim responseValues As String() = responseString.Split(","c)
            ParseResponse(responseValues)
        End Sub

        Protected Friend Overrides Sub ParseResponse(responseValues As String())
            MyBase.ParseResponse(responseValues)
            CommandDescriptions = New List(Of CommandDescription)()
            Dim commandCount As Integer = CInt(responseValues(Fields.Count))
            For idx As Integer = Fields.Count + 1 To commandCount + Fields.Count - 1
                CommandDescriptions.Add(New CommandDescription(responseValues(idx)))
            Next
        End Sub

    End Class

End Namespace