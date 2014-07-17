Public Class MessageViewer

    Private _message As INetworkMessage = Nothing
    Public Property Message As INetworkMessage
        Get
            Return _message
        End Get
        Set(value As INetworkMessage)
            _message = value
            DisplayMessage()
        End Set
    End Property

    Private Sub DisplayMessage()
        If (_message Is Nothing) Then Return
        Me.SubjectTextBox.Text = _message.Subject
        Me.MessageBrowser.DocumentText = Message.Body
    End Sub

End Class
