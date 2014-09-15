Namespace Views.Contacts

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ContactListView
        Inherits BulkMailLibrary.ConstantContact.Views.ConstantContaceViewBase

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
            Me.components = New System.ComponentModel.Container()
            Dim ContactCountLabel As System.Windows.Forms.Label
            Dim DateCreatedLabel As System.Windows.Forms.Label
            Dim DateModifiedLabel As System.Windows.Forms.Label
            Dim IdLabel As System.Windows.Forms.Label
            Dim NameLabel As System.Windows.Forms.Label
            Dim StatusLabel As System.Windows.Forms.Label
            Me.ContactListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ContactCountTextBox = New System.Windows.Forms.TextBox()
            Me.DateCreatedTextBox = New System.Windows.Forms.TextBox()
            Me.DateModifiedTextBox = New System.Windows.Forms.TextBox()
            Me.IdTextBox = New System.Windows.Forms.TextBox()
            Me.NameTextBox = New System.Windows.Forms.TextBox()
            Me.StatusTextBox = New System.Windows.Forms.TextBox()
            Me.SaveButton = New System.Windows.Forms.Button()
            ContactCountLabel = New System.Windows.Forms.Label()
            DateCreatedLabel = New System.Windows.Forms.Label()
            DateModifiedLabel = New System.Windows.Forms.Label()
            IdLabel = New System.Windows.Forms.Label()
            NameLabel = New System.Windows.Forms.Label()
            StatusLabel = New System.Windows.Forms.Label()
            CType(Me.ContactListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ContactCountLabel
            '
            ContactCountLabel.AutoSize = True
            ContactCountLabel.Location = New System.Drawing.Point(8, 8)
            ContactCountLabel.Name = "ContactCountLabel"
            ContactCountLabel.Size = New System.Drawing.Size(78, 13)
            ContactCountLabel.TabIndex = 1
            ContactCountLabel.Text = "Contact Count:"
            '
            'DateCreatedLabel
            '
            DateCreatedLabel.AutoSize = True
            DateCreatedLabel.Location = New System.Drawing.Point(8, 34)
            DateCreatedLabel.Name = "DateCreatedLabel"
            DateCreatedLabel.Size = New System.Drawing.Size(73, 13)
            DateCreatedLabel.TabIndex = 3
            DateCreatedLabel.Text = "Date Created:"
            '
            'DateModifiedLabel
            '
            DateModifiedLabel.AutoSize = True
            DateModifiedLabel.Location = New System.Drawing.Point(8, 60)
            DateModifiedLabel.Name = "DateModifiedLabel"
            DateModifiedLabel.Size = New System.Drawing.Size(76, 13)
            DateModifiedLabel.TabIndex = 5
            DateModifiedLabel.Text = "Date Modified:"
            '
            'IdLabel
            '
            IdLabel.AutoSize = True
            IdLabel.Location = New System.Drawing.Point(8, 87)
            IdLabel.Name = "IdLabel"
            IdLabel.Size = New System.Drawing.Size(19, 13)
            IdLabel.TabIndex = 7
            IdLabel.Text = "Id:"
            '
            'NameLabel
            '
            NameLabel.AutoSize = True
            NameLabel.Location = New System.Drawing.Point(8, 112)
            NameLabel.Name = "NameLabel"
            NameLabel.Size = New System.Drawing.Size(38, 13)
            NameLabel.TabIndex = 9
            NameLabel.Text = "Name:"
            '
            'StatusLabel
            '
            StatusLabel.AutoSize = True
            StatusLabel.Location = New System.Drawing.Point(8, 138)
            StatusLabel.Name = "StatusLabel"
            StatusLabel.Size = New System.Drawing.Size(40, 13)
            StatusLabel.TabIndex = 11
            StatusLabel.Text = "Status:"
            '
            'ContactListBindingSource
            '
            Me.ContactListBindingSource.DataSource = GetType(CTCT.Components.Contacts.ContactList)
            '
            'ContactCountTextBox
            '
            Me.ContactCountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactListBindingSource, "ContactCount", True))
            Me.ContactCountTextBox.Location = New System.Drawing.Point(96, 5)
            Me.ContactCountTextBox.Name = "ContactCountTextBox"
            Me.ContactCountTextBox.Size = New System.Drawing.Size(264, 20)
            Me.ContactCountTextBox.TabIndex = 2
            '
            'DateCreatedTextBox
            '
            Me.DateCreatedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactListBindingSource, "DateCreated", True))
            Me.DateCreatedTextBox.Location = New System.Drawing.Point(96, 31)
            Me.DateCreatedTextBox.Name = "DateCreatedTextBox"
            Me.DateCreatedTextBox.Size = New System.Drawing.Size(264, 20)
            Me.DateCreatedTextBox.TabIndex = 4
            '
            'DateModifiedTextBox
            '
            Me.DateModifiedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactListBindingSource, "DateModified", True))
            Me.DateModifiedTextBox.Location = New System.Drawing.Point(96, 57)
            Me.DateModifiedTextBox.Name = "DateModifiedTextBox"
            Me.DateModifiedTextBox.Size = New System.Drawing.Size(264, 20)
            Me.DateModifiedTextBox.TabIndex = 6
            '
            'IdTextBox
            '
            Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactListBindingSource, "Id", True))
            Me.IdTextBox.Location = New System.Drawing.Point(96, 83)
            Me.IdTextBox.Name = "IdTextBox"
            Me.IdTextBox.Size = New System.Drawing.Size(264, 20)
            Me.IdTextBox.TabIndex = 8
            '
            'NameTextBox
            '
            Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactListBindingSource, "Name", True))
            Me.NameTextBox.Location = New System.Drawing.Point(96, 109)
            Me.NameTextBox.Name = "NameTextBox"
            Me.NameTextBox.Size = New System.Drawing.Size(264, 20)
            Me.NameTextBox.TabIndex = 10
            '
            'StatusTextBox
            '
            Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactListBindingSource, "Status", True))
            Me.StatusTextBox.Location = New System.Drawing.Point(96, 135)
            Me.StatusTextBox.Name = "StatusTextBox"
            Me.StatusTextBox.Size = New System.Drawing.Size(264, 20)
            Me.StatusTextBox.TabIndex = 12
            '
            'SaveButton
            '
            Me.SaveButton.Location = New System.Drawing.Point(288, 168)
            Me.SaveButton.Name = "SaveButton"
            Me.SaveButton.Size = New System.Drawing.Size(75, 23)
            Me.SaveButton.TabIndex = 13
            Me.SaveButton.Text = "Save"
            Me.SaveButton.UseVisualStyleBackColor = True
            '
            'ContactListView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.SaveButton)
            Me.Controls.Add(ContactCountLabel)
            Me.Controls.Add(Me.ContactCountTextBox)
            Me.Controls.Add(DateCreatedLabel)
            Me.Controls.Add(Me.DateCreatedTextBox)
            Me.Controls.Add(DateModifiedLabel)
            Me.Controls.Add(Me.DateModifiedTextBox)
            Me.Controls.Add(IdLabel)
            Me.Controls.Add(Me.IdTextBox)
            Me.Controls.Add(NameLabel)
            Me.Controls.Add(Me.NameTextBox)
            Me.Controls.Add(StatusLabel)
            Me.Controls.Add(Me.StatusTextBox)
            Me.Name = "ContactListView"
            Me.Size = New System.Drawing.Size(460, 264)
            CType(Me.ContactListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents ContactListBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents ContactCountTextBox As System.Windows.Forms.TextBox
        Friend WithEvents DateCreatedTextBox As System.Windows.Forms.TextBox
        Friend WithEvents DateModifiedTextBox As System.Windows.Forms.TextBox
        Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
        Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
        Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
        Friend WithEvents SaveButton As System.Windows.Forms.Button

    End Class

End Namespace