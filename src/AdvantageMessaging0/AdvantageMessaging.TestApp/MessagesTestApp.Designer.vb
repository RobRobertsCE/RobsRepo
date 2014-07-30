<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessagesTestApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.LoadAllMessagesButton = New System.Windows.Forms.Button()
        Me.MessageListBox = New System.Windows.Forms.ListBox()
        Me.LoadNewMessagesButton = New System.Windows.Forms.Button()
        Me.BodyTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmployeeNumberTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewMessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddReadMessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSavedMessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoadAllMessagesButton
        '
        Me.LoadAllMessagesButton.Location = New System.Drawing.Point(13, 27)
        Me.LoadAllMessagesButton.Name = "LoadAllMessagesButton"
        Me.LoadAllMessagesButton.Size = New System.Drawing.Size(108, 50)
        Me.LoadAllMessagesButton.TabIndex = 0
        Me.LoadAllMessagesButton.Text = "All Messages (INBOX Example)"
        Me.LoadAllMessagesButton.UseVisualStyleBackColor = True
        '
        'MessageListBox
        '
        Me.MessageListBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MessageListBox.FormattingEnabled = True
        Me.MessageListBox.Location = New System.Drawing.Point(13, 83)
        Me.MessageListBox.Name = "MessageListBox"
        Me.MessageListBox.Size = New System.Drawing.Size(255, 277)
        Me.MessageListBox.TabIndex = 1
        '
        'LoadNewMessagesButton
        '
        Me.LoadNewMessagesButton.Location = New System.Drawing.Point(146, 27)
        Me.LoadNewMessagesButton.Name = "LoadNewMessagesButton"
        Me.LoadNewMessagesButton.Size = New System.Drawing.Size(122, 50)
        Me.LoadNewMessagesButton.TabIndex = 2
        Me.LoadNewMessagesButton.Text = "New Messages (SPLASH SCREEN Example)"
        Me.LoadNewMessagesButton.UseVisualStyleBackColor = True
        '
        'BodyTextBox
        '
        Me.BodyTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BodyTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.BodyTextBox.Location = New System.Drawing.Point(275, 83)
        Me.BodyTextBox.Multiline = True
        Me.BodyTextBox.Name = "BodyTextBox"
        Me.BodyTextBox.Size = New System.Drawing.Size(581, 271)
        Me.BodyTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(684, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Employee Number:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmployeeNumberTextBox
        '
        Me.EmployeeNumberTextBox.Location = New System.Drawing.Point(787, 27)
        Me.EmployeeNumberTextBox.Name = "EmployeeNumberTextBox"
        Me.EmployeeNumberTextBox.Size = New System.Drawing.Size(69, 20)
        Me.EmployeeNumberTextBox.TabIndex = 5
        Me.EmployeeNumberTextBox.Text = "168"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(868, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewMessageToolStripMenuItem, Me.AddReadMessageToolStripMenuItem, Me.AddSavedMessageToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewMessageToolStripMenuItem
        '
        Me.NewMessageToolStripMenuItem.Name = "NewMessageToolStripMenuItem"
        Me.NewMessageToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.NewMessageToolStripMenuItem.Text = "Add &New Message"
        '
        'AddReadMessageToolStripMenuItem
        '
        Me.AddReadMessageToolStripMenuItem.Name = "AddReadMessageToolStripMenuItem"
        Me.AddReadMessageToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.AddReadMessageToolStripMenuItem.Text = "Add &Read Message"
        '
        'AddSavedMessageToolStripMenuItem
        '
        Me.AddSavedMessageToolStripMenuItem.Name = "AddSavedMessageToolStripMenuItem"
        Me.AddSavedMessageToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.AddSavedMessageToolStripMenuItem.Text = "Add &Saved Message"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(176, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'MessagesTestApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 372)
        Me.Controls.Add(Me.EmployeeNumberTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BodyTextBox)
        Me.Controls.Add(Me.LoadNewMessagesButton)
        Me.Controls.Add(Me.MessageListBox)
        Me.Controls.Add(Me.LoadAllMessagesButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MessagesTestApp"
        Me.Text = "Messages TestApp"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoadAllMessagesButton As System.Windows.Forms.Button
    Friend WithEvents MessageListBox As System.Windows.Forms.ListBox
    Friend WithEvents LoadNewMessagesButton As System.Windows.Forms.Button
    Friend WithEvents BodyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EmployeeNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewMessageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddReadMessageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSavedMessageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
