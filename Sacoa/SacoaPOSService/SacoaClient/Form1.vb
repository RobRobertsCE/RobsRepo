Imports SacoaPOSService
Imports SacoaPOSService.Service

Public Class Form1
    Private Const PosId As String = "1234"
    Private Const EmpId As String = "5678"
    Private Const TestServer As String = "200.80.220.106"
    Private Const TestPort As Integer = 14434

    Dim service As SacoaService = Nothing

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            service = New SacoaService(TestPort, TestServer)

        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub

    Private Sub ExceptionHandler(ex As Exception)
        Display(ex.Message)
        Console.WriteLine(ex.ToString())
    End Sub

    Private Sub Display(message As String)
        txtDisplay.AppendText(message & Environment.NewLine)
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Try
            Dim secoaCommand As New SacoaPOSService.Commands.SecoaSupportedCommandsCommand(PosId, EmpId)
            Dim secoaResponse As SacoaPOSService.Responses.SecoaSupportedCommandsResponse = service.SendCommand(secoaCommand)

            DisplayResponse(secoaResponse)

        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub

    Private Sub DisplayResponse(response As SacoaPOSService.Responses.SecoaSupportedCommandsResponse)
        Display(String.Format("Response Name: {0}", response.ResponseName))
        Display(String.Format("Response Status: {0}", response.ResponseState))

        For Each op As SacoaPOSService.Logic.SecoaOpDescription In response.OpDescriptions
            Display(String.Format("  Op Name: {0}", op.CommandName))
            Display(String.Format("  Op Container: {0}", op.OpContainerName))
            Display(String.Format("  Op Params ({0})", op.CommandParamList.Count))
            Display("---------------------")
            For Each param As String In op.CommandParamList
                Display(String.Format("    {0}", param))
            Next
            Display(Environment.NewLine)
        Next

    End Sub

    Private Sub btnSendAsync_Click(sender As Object, e As EventArgs) Handles btnSendAsync.Click
        Try
            Dim secoaCommand As New SacoaPOSService.Commands.SecoaSupportedCommandsCommand(PosId, EmpId)
            service.SendCommandAsync(secoaCommand, AddressOf SecoaResponseDelegate)

        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub

    Public Sub SecoaResponseDelegate(e As SacoaPOSService.Responses.ISecoaResponse)
        Try
            Dim response As SacoaPOSService.Responses.SecoaSupportedCommandsResponse = DirectCast(e, SacoaPOSService.Responses.SecoaSupportedCommandsResponse)
            DisplayResponse(response)
        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub
End Class
