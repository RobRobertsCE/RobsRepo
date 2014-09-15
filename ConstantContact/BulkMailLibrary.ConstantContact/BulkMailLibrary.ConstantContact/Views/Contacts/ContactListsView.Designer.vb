Namespace Views.Contacts

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ContactListsView
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
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.ContactListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ContactListDataGridView = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType(Me.ContactListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ContactListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ContactListBindingSource
            '
            Me.ContactListBindingSource.DataSource = GetType(CTCT.Components.Contacts.ContactList)
            '
            'ContactListDataGridView
            '
            Me.ContactListDataGridView.AllowUserToOrderColumns = True
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.ContactListDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.ContactListDataGridView.AutoGenerateColumns = False
            Me.ContactListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
            Me.ContactListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.ContactListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
            Me.ContactListDataGridView.DataSource = Me.ContactListBindingSource
            Me.ContactListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ContactListDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
            Me.ContactListDataGridView.Location = New System.Drawing.Point(0, 0)
            Me.ContactListDataGridView.MultiSelect = False
            Me.ContactListDataGridView.Name = "ContactListDataGridView"
            Me.ContactListDataGridView.ReadOnly = True
            Me.ContactListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.ContactListDataGridView.Size = New System.Drawing.Size(876, 422)
            Me.ContactListDataGridView.TabIndex = 1
            '
            'DataGridViewTextBoxColumn1
            '
            Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
            Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.ReadOnly = True
            Me.DataGridViewTextBoxColumn1.Width = 41
            '
            'DataGridViewTextBoxColumn2
            '
            Me.DataGridViewTextBoxColumn2.DataPropertyName = "Status"
            Me.DataGridViewTextBoxColumn2.HeaderText = "Status"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            Me.DataGridViewTextBoxColumn2.ReadOnly = True
            Me.DataGridViewTextBoxColumn2.Width = 62
            '
            'DataGridViewTextBoxColumn3
            '
            Me.DataGridViewTextBoxColumn3.DataPropertyName = "ContactCount"
            Me.DataGridViewTextBoxColumn3.HeaderText = "ContactCount"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.ReadOnly = True
            Me.DataGridViewTextBoxColumn3.Width = 97
            '
            'DataGridViewTextBoxColumn4
            '
            Me.DataGridViewTextBoxColumn4.DataPropertyName = "Name"
            Me.DataGridViewTextBoxColumn4.HeaderText = "Name"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.ReadOnly = True
            Me.DataGridViewTextBoxColumn4.Width = 60
            '
            'DataGridViewTextBoxColumn5
            '
            Me.DataGridViewTextBoxColumn5.DataPropertyName = "DateCreated"
            Me.DataGridViewTextBoxColumn5.HeaderText = "DateCreated"
            Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
            Me.DataGridViewTextBoxColumn5.ReadOnly = True
            Me.DataGridViewTextBoxColumn5.Width = 92
            '
            'DataGridViewTextBoxColumn6
            '
            Me.DataGridViewTextBoxColumn6.DataPropertyName = "DateModified"
            Me.DataGridViewTextBoxColumn6.HeaderText = "DateModified"
            Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
            Me.DataGridViewTextBoxColumn6.ReadOnly = True
            Me.DataGridViewTextBoxColumn6.Width = 95
            '
            'ContactListsView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.ContactListDataGridView)
            Me.Name = "ContactListsView"
            Me.Size = New System.Drawing.Size(876, 422)
            CType(Me.ContactListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ContactListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents ContactListBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents ContactListDataGridView As System.Windows.Forms.DataGridView
        Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class

End Namespace