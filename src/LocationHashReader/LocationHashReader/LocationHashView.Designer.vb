<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LocationHashView
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
        Me.getHashButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.locationComboBox = New System.Windows.Forms.ComboBox()
        Me.copyHashButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'getHashButton
        '
        Me.getHashButton.Enabled = False
        Me.getHashButton.Location = New System.Drawing.Point(447, 40)
        Me.getHashButton.Name = "getHashButton"
        Me.getHashButton.Size = New System.Drawing.Size(75, 23)
        Me.getHashButton.TabIndex = 0
        Me.getHashButton.Text = "Get Hash"
        Me.getHashButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(14, 69)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(508, 20)
        Me.TextBox1.TabIndex = 1
        '
        'locationComboBox
        '
        Me.locationComboBox.FormattingEnabled = True
        Me.locationComboBox.Location = New System.Drawing.Point(14, 42)
        Me.locationComboBox.Name = "locationComboBox"
        Me.locationComboBox.Size = New System.Drawing.Size(427, 21)
        Me.locationComboBox.TabIndex = 2
        '
        'copyHashButton
        '
        Me.copyHashButton.Enabled = False
        Me.copyHashButton.Location = New System.Drawing.Point(447, 95)
        Me.copyHashButton.Name = "copyHashButton"
        Me.copyHashButton.Size = New System.Drawing.Size(75, 23)
        Me.copyHashButton.TabIndex = 3
        Me.copyHashButton.Text = "Copy Hash"
        Me.copyHashButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select a Location"
        '
        'LocationHashView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 130)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.copyHashButton)
        Me.Controls.Add(Me.locationComboBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.getHashButton)
        Me.Name = "LocationHashView"
        Me.Text = "SiteInfo Location Hash Reader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents getHashButton As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents locationComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents copyHashButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
