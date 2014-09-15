Namespace Views

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class CompositeContactListView
        Inherits ConstantContaceViewBase

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
            Me.ContactListsView1 = New BulkMailLibrary.ConstantContact.Views.Contacts.ContactListsView()
            Me.ContactListView1 = New BulkMailLibrary.ConstantContact.Views.Contacts.ContactListView()
            Me.Splitter1 = New System.Windows.Forms.Splitter()
            Me.SuspendLayout()
            '
            'ContactListsView1
            '
            Me.ContactListsView1.AccountInfo = Nothing
            Me.ContactListsView1.AutoScroll = True
            Me.ContactListsView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ContactListsView1.Location = New System.Drawing.Point(0, 0)
            Me.ContactListsView1.Name = "ContactListsView1"
            Me.ContactListsView1.Size = New System.Drawing.Size(681, 288)
            Me.ContactListsView1.TabIndex = 0
            '
            'ContactListView1
            '
            Me.ContactListView1.AccountInfo = Nothing
            Me.ContactListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.ContactListView1.ContactList = Nothing
            Me.ContactListView1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.ContactListView1.Location = New System.Drawing.Point(0, 288)
            Me.ContactListView1.Name = "ContactListView1"
            Me.ContactListView1.Size = New System.Drawing.Size(681, 235)
            Me.ContactListView1.TabIndex = 1
            '
            'Splitter1
            '
            Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Splitter1.Location = New System.Drawing.Point(0, 285)
            Me.Splitter1.Name = "Splitter1"
            Me.Splitter1.Size = New System.Drawing.Size(681, 3)
            Me.Splitter1.TabIndex = 2
            Me.Splitter1.TabStop = False
            '
            'CompositeContactListView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Splitter1)
            Me.Controls.Add(Me.ContactListsView1)
            Me.Controls.Add(Me.ContactListView1)
            Me.Name = "CompositeContactListView"
            Me.Size = New System.Drawing.Size(681, 523)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents ContactListsView1 As BulkMailLibrary.ConstantContact.Views.Contacts.ContactListsView
        Friend WithEvents ContactListView1 As BulkMailLibrary.ConstantContact.Views.Contacts.ContactListView
        Friend WithEvents Splitter1 As System.Windows.Forms.Splitter

    End Class

End Namespace