Imports SacoaPOSService.Logic

Namespace Responses

    Public Class SecoaSupportedCommandsResponse
        Inherits SecoaResponse

        Private Enum Fields
            OpCountField = 2
        End Enum

        Private Const ParamStartTag As String = " <pos>"
        
        Public Property OpDescriptions As List(Of SecoaOpDescription)
        Public Property OpContent As String

        Public Sub New(responseString As String)
            ParseResponse(responseString)
        End Sub

        Protected Friend Sub New(responseValues As String())
            ParseResponse(responseValues)
        End Sub

        Protected Friend Overrides Sub ParseResponse(responseString As String)
            Dim responseValues As String() = responseString.Split(SplitOnComma)
            ParseResponse(responseValues)
        End Sub

        Protected Friend Overrides Sub ParseResponse(responseValues As String())
            MyBase.ParseResponse(responseValues)
            Dim startingValueIndex = Fields.OpCountField + 1
            Dim IncludeHandlerInfo As Boolean = False
            Dim OpContainer As String = String.Empty

            OpDescriptions = New List(Of SecoaOpDescription)()
            Dim OpLineCount = CInt(responseValues(Fields.OpCountField))

            If (responseValues.Count - 1 <> OpLineCount + Fields.OpCountField) Then
                Throw New InvalidOperationException("Did not receive valid response from Secoa.")
            End If

            If Not (responseValues(startingValueIndex).StartsWith(ParamStartTag)) Then
                IncludeHandlerInfo = True
                OpContainer = responseValues(startingValueIndex)
                startingValueIndex += 1
            End If

            For valueIndex As Integer = startingValueIndex To OpLineCount - 1
                If IncludeHandlerInfo Then
                    If Not (responseValues(valueIndex).StartsWith(ParamStartTag)) Then
                        OpContainer = responseValues(valueIndex)
                    Else
                        OpDescriptions.Add(New SecoaOpDescription(responseValues(valueIndex), OpContainer))
                    End If
                Else
                    OpDescriptions.Add(New SecoaOpDescription(responseValues(valueIndex), OpContainer))
                End If
            Next
        End Sub

    End Class

End Namespace