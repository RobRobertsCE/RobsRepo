<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.InboxButton = New System.Windows.Forms.Button()
        Me.SplashScreenButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'InboxButton
        '
        Me.InboxButton.Location = New System.Drawing.Point(12, 12)
        Me.InboxButton.Name = "InboxButton"
        Me.InboxButton.Size = New System.Drawing.Size(172, 23)
        Me.InboxButton.TabIndex = 0
        Me.InboxButton.Text = "Inbox"
        Me.InboxButton.UseVisualStyleBackColor = True
        '
        'SplashScreenButton
        '
        Me.SplashScreenButton.Location = New System.Drawing.Point(12, 42)
        Me.SplashScreenButton.Name = "SplashScreenButton"
        Me.SplashScreenButton.Size = New System.Drawing.Size(172, 23)
        Me.SplashScreenButton.TabIndex = 1
        Me.SplashScreenButton.Text = "Splash Screen"
        Me.SplashScreenButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(196, 86)
        Me.Controls.Add(Me.SplashScreenButton)
        Me.Controls.Add(Me.InboxButton)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InboxButton As System.Windows.Forms.Button
    Friend WithEvents SplashScreenButton As System.Windows.Forms.Button

End Class
