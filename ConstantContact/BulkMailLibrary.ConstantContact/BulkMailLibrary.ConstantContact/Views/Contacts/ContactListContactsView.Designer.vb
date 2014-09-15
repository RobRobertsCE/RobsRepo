Imports BulkMailLibrary.ConstantContact.Views

Namespace Views.Contacts

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ContactListContactsView
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
            Me.ContactDisplayModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ContactDisplayModelDataGridView = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType(Me.ContactDisplayModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ContactDisplayModelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ContactDisplayModelBindingSource
            '
            Me.ContactDisplayModelBindingSource.DataSource = GetType(BulkMailLibrary.ConstantContact.Business.ContactDisplayModel)
            '
            'ContactDisplayModelDataGridView
            '
            Me.ContactDisplayModelDataGridView.AutoGenerateColumns = False
            Me.ContactDisplayModelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.ContactDisplayModelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
            Me.ContactDisplayModelDataGridView.DataSource = Me.ContactDisplayModelBindingSource
            Me.ContactDisplayModelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ContactDisplayModelDataGridView.Location = New System.Drawing.Point(0, 0)
            Me.ContactDisplayModelDataGridView.MultiSelect = False
            Me.ContactDisplayModelDataGridView.Name = "ContactDisplayModelDataGridView"
            Me.ContactDisplayModelDataGridView.ReadOnly = True
            Me.ContactDisplayModelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.ContactDisplayModelDataGridView.ShowEditingIcon = False
            Me.ContactDisplayModelDataGridView.Size = New System.Drawing.Size(597, 312)
            Me.ContactDisplayModelDataGridView.TabIndex = 1
            '
            'DataGridViewTextBoxColumn1
            '
            Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
            Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.ReadOnly = True
            '
            'DataGridViewTextBoxColumn2
            '
            Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
            Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            Me.DataGridViewTextBoxColumn2.ReadOnly = True
            '
            'DataGridViewTextBoxColumn3
            '
            Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
            Me.DataGridViewTextBoxColumn3.HeaderText = "LastName"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.ReadOnly = True
            '
            'DataGridViewTextBoxColumn4
            '
            Me.DataGridViewTextBoxColumn4.DataPropertyName = "EMailAddress"
            Me.DataGridViewTextBoxColumn4.HeaderText = "EMailAddress"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.ReadOnly = True
            '
            'DataGridViewTextBoxColumn5
            '
            Me.DataGridViewTextBoxColumn5.DataPropertyName = "Status"
            Me.DataGridViewTextBoxColumn5.HeaderText = "Status"
            Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
            Me.DataGridViewTextBoxColumn5.ReadOnly = True
            '
            'DataGridViewTextBoxColumn6
            '
            Me.DataGridViewTextBoxColumn6.DataPropertyName = "DateCreated"
            Me.DataGridViewTextBoxColumn6.HeaderText = "DateCreated"
            Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
            Me.DataGridViewTextBoxColumn6.ReadOnly = True
            '
            'DataGridViewTextBoxColumn7
            '
            Me.DataGridViewTextBoxColumn7.DataPropertyName = "DateModified"
            Me.DataGridViewTextBoxColumn7.HeaderText = "DateModified"
            Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
            Me.DataGridViewTextBoxColumn7.ReadOnly = True
            '
            'DataGridViewTextBoxColumn8
            '
            Me.DataGridViewTextBoxColumn8.DataPropertyName = "CustomerKey"
            Me.DataGridViewTextBoxColumn8.HeaderText = "CustomerKey"
            Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
            Me.DataGridViewTextBoxColumn8.ReadOnly = True
            '
            'DataGridViewTextBoxColumn9
            '
            Me.DataGridViewTextBoxColumn9.DataPropertyName = "CustomFields"
            Me.DataGridViewTextBoxColumn9.HeaderText = "CustomFields"
            Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
            Me.DataGridViewTextBoxColumn9.ReadOnly = True
            '
            'ContactListContactsView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.ContactDisplayModelDataGridView)
            Me.Name = "ContactListContactsView"
            Me.Size = New System.Drawing.Size(597, 312)
            CType(Me.ContactDisplayModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ContactDisplayModelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents ContactDisplayModelBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents ContactDisplayModelDataGridView As System.Windows.Forms.DataGridView
        Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class

End Namespace