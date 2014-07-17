<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageViewer
    Inherits System.Windows.Forms.UserControl

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
        Me.SubjectTextBox = New System.Windows.Forms.TextBox()
        Me.MessageBrowser = New System.Windows.Forms.WebBrowser()
        Me.SubjectPanel = New AdvUserCtrls.BorderPanel()
        Me.BrowserPanel = New AdvUserCtrls.BorderPanel()
        Me.SubjectPanel.SuspendLayout()
        Me.BrowserPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubjectTextBox
        '
        Me.SubjectTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.SubjectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SubjectTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectTextBox.Location = New System.Drawing.Point(0, 0)
        Me.SubjectTextBox.Multiline = True
        Me.SubjectTextBox.Name = "SubjectTextBox"
        Me.SubjectTextBox.Size = New System.Drawing.Size(498, 19)
        Me.SubjectTextBox.TabIndex = 0
        '
        'MessageBrowser
        '
        Me.MessageBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessageBrowser.Location = New System.Drawing.Point(0, 0)
        Me.MessageBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.MessageBrowser.Name = "MessageBrowser"
        Me.MessageBrowser.Size = New System.Drawing.Size(498, 331)
        Me.MessageBrowser.TabIndex = 1
        '
        'SubjectPanel
        '
        Me.SubjectPanel.BackColor = System.Drawing.SystemColors.Info
        Me.SubjectPanel.Controls.Add(Me.SubjectTextBox)
        Me.SubjectPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubjectPanel.Location = New System.Drawing.Point(0, 0)
        Me.SubjectPanel.Name = "SubjectPanel"
        Me.SubjectPanel.Size = New System.Drawing.Size(500, 19)
        Me.SubjectPanel.TabIndex = 2
        '
        'BrowserPanel
        '
        Me.BrowserPanel.Controls.Add(Me.MessageBrowser)
        Me.BrowserPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrowserPanel.Location = New System.Drawing.Point(0, 19)
        Me.BrowserPanel.Name = "BrowserPanel"
        Me.BrowserPanel.Size = New System.Drawing.Size(500, 333)
        Me.BrowserPanel.TabIndex = 3
        '
        'MessageViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BrowserPanel)
        Me.Controls.Add(Me.SubjectPanel)
        Me.Name = "MessageViewer"
        Me.Size = New System.Drawing.Size(500, 352)
        Me.SubjectPanel.ResumeLayout(False)
        Me.SubjectPanel.PerformLayout()
        Me.BrowserPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SubjectTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MessageBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents SubjectPanel As AdvUserCtrls.BorderPanel
    Friend WithEvents BrowserPanel As AdvUserCtrls.BorderPanel

End Class
