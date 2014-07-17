<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageSplashScreen
    Inherits AdvUserCtrls.AdvDialog


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
        Me.SplashButtonBorderPanel = New AdvUserCtrls.BorderPanel()
        Me.MessageCountLabel = New System.Windows.Forms.Label()
        Me.SplashPrintButton = New AdvUserCtrls.GlassButton()
        Me.SplashNextButton = New AdvUserCtrls.GlassButton()
        Me.MessageViewerControl = New NetworkMessagingUIMockUps.MessageViewer()
        Me.SplashKeepNewButton = New AdvUserCtrls.GlassButton()
        Me.SplashButtonBorderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplashButtonBorderPanel
        '
        Me.SplashButtonBorderPanel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplashButtonBorderPanel.Controls.Add(Me.SplashKeepNewButton)
        Me.SplashButtonBorderPanel.Controls.Add(Me.MessageCountLabel)
        Me.SplashButtonBorderPanel.Controls.Add(Me.SplashPrintButton)
        Me.SplashButtonBorderPanel.Controls.Add(Me.SplashNextButton)
        Me.SplashButtonBorderPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplashButtonBorderPanel.Location = New System.Drawing.Point(0, 590)
        Me.SplashButtonBorderPanel.Name = "SplashButtonBorderPanel"
        Me.SplashButtonBorderPanel.Padding = New System.Windows.Forms.Padding(8)
        Me.SplashButtonBorderPanel.Size = New System.Drawing.Size(984, 65)
        Me.SplashButtonBorderPanel.TabIndex = 0
        '
        'MessageCountLabel
        '
        Me.MessageCountLabel.AutoSize = True
        Me.MessageCountLabel.Location = New System.Drawing.Point(109, 24)
        Me.MessageCountLabel.Name = "MessageCountLabel"
        Me.MessageCountLabel.Size = New System.Drawing.Size(0, 16)
        Me.MessageCountLabel.TabIndex = 3
        '
        'SplashPrintButton
        '
        Me.SplashPrintButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.SplashPrintButton.ImagePadding = New System.Drawing.Size(0, 0)
        Me.SplashPrintButton.Location = New System.Drawing.Point(8, 8)
        Me.SplashPrintButton.Name = "SplashPrintButton"
        Me.SplashPrintButton.Size = New System.Drawing.Size(95, 47)
        Me.SplashPrintButton.TabIndex = 1
        Me.SplashPrintButton.Text = "Print"
        '
        'SplashNextButton
        '
        Me.SplashNextButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SplashNextButton.ImagePadding = New System.Drawing.Size(0, 0)
        Me.SplashNextButton.Location = New System.Drawing.Point(879, 8)
        Me.SplashNextButton.Name = "SplashNextButton"
        Me.SplashNextButton.Size = New System.Drawing.Size(95, 47)
        Me.SplashNextButton.TabIndex = 0
        Me.SplashNextButton.Text = "Next"
        '
        'MessageViewerControl
        '
        Me.MessageViewerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessageViewerControl.Location = New System.Drawing.Point(0, 0)
        Me.MessageViewerControl.Margin = New System.Windows.Forms.Padding(4)
        Me.MessageViewerControl.Message = Nothing
        Me.MessageViewerControl.Name = "MessageViewerControl"
        Me.MessageViewerControl.Size = New System.Drawing.Size(984, 590)
        Me.MessageViewerControl.TabIndex = 1
        '
        'SplashKeepNewButton
        '
        Me.SplashKeepNewButton.ImagePadding = New System.Drawing.Size(0, 0)
        Me.SplashKeepNewButton.Location = New System.Drawing.Point(779, 8)
        Me.SplashKeepNewButton.Name = "SplashKeepNewButton"
        Me.SplashKeepNewButton.Size = New System.Drawing.Size(95, 47)
        Me.SplashKeepNewButton.TabIndex = 4
        Me.SplashKeepNewButton.Text = "Keep As New"
        '
        'MessageSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 655)
        Me.Controls.Add(Me.MessageViewerControl)
        Me.Controls.Add(Me.SplashButtonBorderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "MessageSplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Network Messages"
        Me.SplashButtonBorderPanel.ResumeLayout(False)
        Me.SplashButtonBorderPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplashButtonBorderPanel As AdvUserCtrls.BorderPanel
    Friend WithEvents SplashNextButton As AdvUserCtrls.GlassButton
    Friend WithEvents MessageViewerControl As NetworkMessagingUIMockUps.MessageViewer
    Friend WithEvents SplashPrintButton As AdvUserCtrls.GlassButton
    Friend WithEvents MessageCountLabel As System.Windows.Forms.Label
    Friend WithEvents SplashKeepNewButton As AdvUserCtrls.GlassButton
End Class
