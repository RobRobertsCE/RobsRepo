Public Class Form1

    Private Sub InboxButton_Click(sender As Object, e As EventArgs) Handles InboxButton.Click
        Dim dialog As New MessageInbox()
        dialog.ShowDialog(Me)
    End Sub

    Private Sub SplashScreenButton_Click(sender As Object, e As EventArgs) Handles SplashScreenButton.Click
        Dim dialog As New MessageSplashScreen()
        dialog.ShowDialog(Me)
    End Sub
End Class
