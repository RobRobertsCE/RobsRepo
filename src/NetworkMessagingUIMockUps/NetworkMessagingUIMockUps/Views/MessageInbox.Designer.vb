<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageInbox
    Inherits AdvUserCtrls.AdvDialog

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MessageListBorderPanel = New AdvUserCtrls.BorderPanel()
        Me.MessageListSplitter = New System.Windows.Forms.Splitter()
        Me.InboxButtonPanel = New AdvUserCtrls.BorderPanel()
        Me.InboxCloseButton = New AdvUserCtrls.GlassButton()
        Me.InboxPrintButton = New AdvUserCtrls.GlassButton()
        Me.MessageViewPanel = New AdvUserCtrls.BorderPanel()
        Me.MessageViewerControl = New NetworkMessagingUIMockUps.MessageViewer()
        Me.MessageListControl = New NetworkMessagingUIMockUps.MessageListGrid()
        Me.MessageListBorderPanel.SuspendLayout()
        Me.InboxButtonPanel.SuspendLayout()
        Me.MessageViewPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MessageListBorderPanel
        '
        Me.MessageListBorderPanel.Controls.Add(Me.MessageListControl)
        Me.MessageListBorderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MessageListBorderPanel.Location = New System.Drawing.Point(0, 0)
        Me.MessageListBorderPanel.Name = "MessageListBorderPanel"
        Me.MessageListBorderPanel.Size = New System.Drawing.Size(984, 134)
        Me.MessageListBorderPanel.TabIndex = 0
        '
        'MessageListSplitter
        '
        Me.MessageListSplitter.Dock = System.Windows.Forms.DockStyle.Top
        Me.MessageListSplitter.Location = New System.Drawing.Point(0, 134)
        Me.MessageListSplitter.Name = "MessageListSplitter"
        Me.MessageListSplitter.Size = New System.Drawing.Size(984, 3)
        Me.MessageListSplitter.TabIndex = 1
        Me.MessageListSplitter.TabStop = False
        '
        'InboxButtonPanel
        '
        Me.InboxButtonPanel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.InboxButtonPanel.Controls.Add(Me.InboxCloseButton)
        Me.InboxButtonPanel.Controls.Add(Me.InboxPrintButton)
        Me.InboxButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.InboxButtonPanel.Location = New System.Drawing.Point(0, 595)
        Me.InboxButtonPanel.Name = "InboxButtonPanel"
        Me.InboxButtonPanel.Padding = New System.Windows.Forms.Padding(5)
        Me.InboxButtonPanel.Size = New System.Drawing.Size(984, 60)
        Me.InboxButtonPanel.TabIndex = 2
        '
        'InboxCloseButton
        '
        Me.InboxCloseButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.InboxCloseButton.ImagePadding = New System.Drawing.Size(0, 0)
        Me.InboxCloseButton.Location = New System.Drawing.Point(877, 5)
        Me.InboxCloseButton.Name = "InboxCloseButton"
        Me.InboxCloseButton.Size = New System.Drawing.Size(100, 48)
        Me.InboxCloseButton.TabIndex = 1
        Me.InboxCloseButton.Text = "Close"
        '
        'InboxPrintButton
        '
        Me.InboxPrintButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.InboxPrintButton.ImagePadding = New System.Drawing.Size(0, 0)
        Me.InboxPrintButton.Location = New System.Drawing.Point(5, 5)
        Me.InboxPrintButton.Name = "InboxPrintButton"
        Me.InboxPrintButton.Size = New System.Drawing.Size(100, 48)
        Me.InboxPrintButton.TabIndex = 0
        Me.InboxPrintButton.Text = "Print"
        '
        'MessageViewPanel
        '
        Me.MessageViewPanel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MessageViewPanel.Controls.Add(Me.MessageViewerControl)
        Me.MessageViewPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessageViewPanel.Location = New System.Drawing.Point(0, 137)
        Me.MessageViewPanel.Name = "MessageViewPanel"
        Me.MessageViewPanel.Size = New System.Drawing.Size(984, 458)
        Me.MessageViewPanel.TabIndex = 3
        '
        'MessageViewerControl
        '
        Me.MessageViewerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessageViewerControl.Location = New System.Drawing.Point(0, 0)
        Me.MessageViewerControl.Margin = New System.Windows.Forms.Padding(4)
        Me.MessageViewerControl.Message = Nothing
        Me.MessageViewerControl.Name = "MessageViewerControl"
        Me.MessageViewerControl.Size = New System.Drawing.Size(982, 456)
        Me.MessageViewerControl.TabIndex = 0
        '
        'MessageListControl
        '
        Me.MessageListControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessageListControl.Location = New System.Drawing.Point(0, 0)
        Me.MessageListControl.Margin = New System.Windows.Forms.Padding(4)
        Me.MessageListControl.Name = "MessageListControl"
        Me.MessageListControl.Size = New System.Drawing.Size(982, 132)
        Me.MessageListControl.TabIndex = 0
        '
        'MessageInbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 655)
        Me.Controls.Add(Me.MessageViewPanel)
        Me.Controls.Add(Me.InboxButtonPanel)
        Me.Controls.Add(Me.MessageListSplitter)
        Me.Controls.Add(Me.MessageListBorderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MessageInbox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Network Messaging - Inbox"
        Me.MessageListBorderPanel.ResumeLayout(False)
        Me.InboxButtonPanel.ResumeLayout(False)
        Me.MessageViewPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MessageListBorderPanel As AdvUserCtrls.BorderPanel
    Friend WithEvents MessageListSplitter As System.Windows.Forms.Splitter
    Friend WithEvents InboxButtonPanel As AdvUserCtrls.BorderPanel
    Friend WithEvents InboxCloseButton As AdvUserCtrls.GlassButton
    Friend WithEvents InboxPrintButton As AdvUserCtrls.GlassButton
    Friend WithEvents MessageViewPanel As AdvUserCtrls.BorderPanel
    Friend WithEvents MessageListControl As NetworkMessagingUIMockUps.MessageListGrid
    Friend WithEvents MessageViewerControl As NetworkMessagingUIMockUps.MessageViewer

End Class
