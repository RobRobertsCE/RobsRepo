Imports SacoaPOSService.Logic

Namespace Responses

    Public Class SecoaSupportedCommandsResponse
        Inherits SecoaResponse

        Private Enum Fields
            Count = 2
            FirstOpContainer = 3
            FirstOpDescription = 4
        End Enum

        Public Property OpDescriptions As List(Of SecoaOpDescription)
        Public Property OpCount As Integer
        Public Property OpContent As String

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
            OpCount = CInt(responseValues(Fields.Count))
            Dim OpContainer As String = responseValues(Fields.FirstOpContainer)

            For idx As Integer = Fields.FirstOpDescription To responseValues.Count - 1
                If (responseValues(idx).StartsWith(" <pos>")) Then
                    Try
                        OpDescriptions.Add(New SecoaOpDescription(responseValues(idx), OpContainer))
                    Catch ex As Exception
                        Console.WriteLine(ex.ToString())
                    End Try
                    OpDescriptions.Add(New SecoaOpDescription(responseValues(idx), OpContainer))
                Else
                    OpContainer = responseValues(idx)
                    Console.WriteLine("OpContainer=" & OpContainer)
                End If

            Next
        End Sub

    End Class

End Namespace