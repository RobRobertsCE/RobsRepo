Imports SacoaPOSService.Logic

Namespace Responses

    Public Class SecoaSupportedCommandsResponse
        Inherits SecoaResponse

        Private Enum Fields
            Count = 2
        End Enum

        Public Property OpDescriptions As List(Of SecoaOpDescription)

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
            OpDescriptions = New List(Of SecoaOpDescription)()
            Dim opCount As Integer = CInt(responseValues(Fields.Count))
            For idx As Integer = Fields.Count + 1 To opCount + Fields.Count - 1
                OpDescriptions.Add(New SecoaOpDescription(responseValues(idx)))
            Next
        End Sub

    End Class

End Namespace