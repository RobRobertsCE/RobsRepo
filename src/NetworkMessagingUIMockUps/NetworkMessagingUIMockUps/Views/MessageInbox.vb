Public Class MessageInbox
    Inherits AdvUserCtrls.AdvDialog

    Private _messages As New NetworkMessageList()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        LoadMessages()

    End Sub

    Private Sub LoadMessages()

        _messages.Add(New NetworkMessage(Guid.NewGuid(), "CenterEdge Advantage 14.1 Released!", My.Resources.Message1, DateTime.Now, True))
        _messages.Add(New NetworkMessage(Guid.NewGuid(), "CenterEdge - Last Chance, Act Now & Save through July 15, 2014", My.Resources.Message1, DateTime.Now.AddDays(-3), True))
        _messages.Add(New NetworkMessage(Guid.NewGuid(), "Reminder: 4th of July 2014", My.Resources.Message2, DateTime.Now.AddDays(-4), False))
        _messages.Add(New NetworkMessage(Guid.NewGuid(), "CenterEdge - Upgrade Now & Save through July 15, 2014", My.Resources.Message3, DateTime.Now.AddDays(-12), False))
        _messages.Add(New NetworkMessage(Guid.NewGuid(), "CenterEdge Phone System Outage", My.Resources.Message5, DateTime.Now.AddDays(-20), True))

        For Each m As NetworkMessage In _messages
            MessageListControl.MessageListDataSource.Rows.Add(New Object() {m.MessageId, m.ExpirationDate, m.Subject, m.IsUnread})
        Next

    End Sub

    Private Sub InboxCloseButton_Click(sender As Object, e As EventArgs) Handles InboxCloseButton.Click
        Me.Close()
    End Sub

    Private Sub MessageListControl_MessageSelected(sender As Object, e As EventArgs) Handles MessageListControl.MessageSelected
        Try
            If sender Is Nothing Then Return

            Dim m As INetworkMessage = GetMessage(sender)

            If (m Is Nothing) Then Return

            ViewMessage(m)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function GetMessage(id As Guid) As INetworkMessage
        Return _messages.Find(Function(m) m.MessageId.Equals(id))
    End Function

    Private Sub ViewMessage(message As INetworkMessage)
        MessageViewerControl.Message = message
    End Sub

End Class
