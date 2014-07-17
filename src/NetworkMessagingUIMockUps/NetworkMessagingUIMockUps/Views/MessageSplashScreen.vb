Public Class MessageSplashScreen
    Inherits AdvUserCtrls.AdvDialog

    Private _messages As New NetworkMessageList()

    Private _messageIdx As Integer = -1

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        LoadMessages()

        MoveNext()

    End Sub


    Private Sub LoadMessages()

        _messages.Add(New NetworkMessage(Guid.NewGuid(), "CenterEdge Advantage 14.1 Released!", My.Resources.Message1, DateTime.Now, True))
        _messages.Add(New NetworkMessage(Guid.NewGuid(), "CenterEdge - Last Chance, Act Now & Save through July 15, 2014", My.Resources.Message1, DateTime.Now.AddDays(-3), True))
        _messages.Add(New NetworkMessage(Guid.NewGuid(), "Reminder: 4th of July 2014", My.Resources.Message2, DateTime.Now.AddDays(-4), False))
        _messages.Add(New NetworkMessage(Guid.NewGuid(), "CenterEdge - Upgrade Now & Save through July 15, 2014", My.Resources.Message3, DateTime.Now.AddDays(-12), False))
        _messages.Add(New NetworkMessage(Guid.NewGuid(), "CenterEdge Phone System Outage", My.Resources.Message5, DateTime.Now.AddDays(-20), True))

    End Sub

    Private Sub LoadMessage(message As INetworkMessage)
        MessageViewerControl.Message = message
    End Sub

    Private Sub MoveNext()
        _messageIdx += 1

        MessageCountLabel.Text = String.Format("Message {0} of {1}", _messageIdx + 1, _messages.Count)
        If _messageIdx < _messages.Count Then
            LoadMessage(_messages(_messageIdx))
        End If

    End Sub

    Private Sub SplashNextButton_Click(sender As Object, e As EventArgs) Handles SplashOkButton.Click
        If (_messageIdx = _messages.Count - 1) Then
            Me.Close()
        End If

        MoveNext()

    End Sub



End Class