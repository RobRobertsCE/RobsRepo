Imports BulkMailLibrary.ConstantContact.Views

Namespace Views.Activities
    
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ActivityView
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
            Dim ContactCountLabel As System.Windows.Forms.Label
            Dim CreatedDateLabel As System.Windows.Forms.Label
            Dim ErrorCountLabel As System.Windows.Forms.Label
            Dim FileNameLabel As System.Windows.Forms.Label
            Dim FinishDateLabel As System.Windows.Forms.Label
            Dim IdLabel As System.Windows.Forms.Label
            Dim StartDateLabel As System.Windows.Forms.Label
            Dim StatusLabel As System.Windows.Forms.Label
            Dim TypeLabel As System.Windows.Forms.Label
            Me.ActivityDataGridView = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ActivityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ContactCountTextBox = New System.Windows.Forms.TextBox()
            Me.CreatedDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
            Me.ErrorCountTextBox = New System.Windows.Forms.TextBox()
            Me.FileNameTextBox = New System.Windows.Forms.TextBox()
            Me.FinishDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
            Me.IdTextBox = New System.Windows.Forms.TextBox()
            Me.StartDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
            Me.StatusTextBox = New System.Windows.Forms.TextBox()
            Me.TypeTextBox = New System.Windows.Forms.TextBox()
            Me.ErrorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ErrorsDataGridView = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.WarningsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ErrorsDataGridView1 = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            ContactCountLabel = New System.Windows.Forms.Label()
            CreatedDateLabel = New System.Windows.Forms.Label()
            ErrorCountLabel = New System.Windows.Forms.Label()
            FileNameLabel = New System.Windows.Forms.Label()
            FinishDateLabel = New System.Windows.Forms.Label()
            IdLabel = New System.Windows.Forms.Label()
            StartDateLabel = New System.Windows.Forms.Label()
            StatusLabel = New System.Windows.Forms.Label()
            TypeLabel = New System.Windows.Forms.Label()
            CType(Me.ActivityDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ActivityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrorsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.WarningsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrorsDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ContactCountLabel
            '
            ContactCountLabel.AutoSize = True
            ContactCountLabel.Location = New System.Drawing.Point(8, 256)
            ContactCountLabel.Name = "ContactCountLabel"
            ContactCountLabel.Size = New System.Drawing.Size(78, 13)
            ContactCountLabel.TabIndex = 1
            ContactCountLabel.Text = "Contact Count:"
            '
            'CreatedDateLabel
            '
            CreatedDateLabel.AutoSize = True
            CreatedDateLabel.Location = New System.Drawing.Point(8, 283)
            CreatedDateLabel.Name = "CreatedDateLabel"
            CreatedDateLabel.Size = New System.Drawing.Size(73, 13)
            CreatedDateLabel.TabIndex = 3
            CreatedDateLabel.Text = "Created Date:"
            '
            'ErrorCountLabel
            '
            ErrorCountLabel.AutoSize = True
            ErrorCountLabel.Location = New System.Drawing.Point(8, 308)
            ErrorCountLabel.Name = "ErrorCountLabel"
            ErrorCountLabel.Size = New System.Drawing.Size(63, 13)
            ErrorCountLabel.TabIndex = 5
            ErrorCountLabel.Text = "Error Count:"
            '
            'FileNameLabel
            '
            FileNameLabel.AutoSize = True
            FileNameLabel.Location = New System.Drawing.Point(8, 334)
            FileNameLabel.Name = "FileNameLabel"
            FileNameLabel.Size = New System.Drawing.Size(57, 13)
            FileNameLabel.TabIndex = 7
            FileNameLabel.Text = "File Name:"
            '
            'FinishDateLabel
            '
            FinishDateLabel.AutoSize = True
            FinishDateLabel.Location = New System.Drawing.Point(8, 361)
            FinishDateLabel.Name = "FinishDateLabel"
            FinishDateLabel.Size = New System.Drawing.Size(63, 13)
            FinishDateLabel.TabIndex = 9
            FinishDateLabel.Text = "Finish Date:"
            '
            'IdLabel
            '
            IdLabel.AutoSize = True
            IdLabel.Location = New System.Drawing.Point(8, 386)
            IdLabel.Name = "IdLabel"
            IdLabel.Size = New System.Drawing.Size(19, 13)
            IdLabel.TabIndex = 11
            IdLabel.Text = "Id:"
            '
            'StartDateLabel
            '
            StartDateLabel.AutoSize = True
            StartDateLabel.Location = New System.Drawing.Point(8, 413)
            StartDateLabel.Name = "StartDateLabel"
            StartDateLabel.Size = New System.Drawing.Size(58, 13)
            StartDateLabel.TabIndex = 13
            StartDateLabel.Text = "Start Date:"
            '
            'StatusLabel
            '
            StatusLabel.AutoSize = True
            StatusLabel.Location = New System.Drawing.Point(8, 438)
            StatusLabel.Name = "StatusLabel"
            StatusLabel.Size = New System.Drawing.Size(40, 13)
            StatusLabel.TabIndex = 15
            StatusLabel.Text = "Status:"
            '
            'TypeLabel
            '
            TypeLabel.AutoSize = True
            TypeLabel.Location = New System.Drawing.Point(8, 464)
            TypeLabel.Name = "TypeLabel"
            TypeLabel.Size = New System.Drawing.Size(34, 13)
            TypeLabel.TabIndex = 17
            TypeLabel.Text = "Type:"
            '
            'ActivityDataGridView
            '
            Me.ActivityDataGridView.AutoGenerateColumns = False
            Me.ActivityDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
            Me.ActivityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.ActivityDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
            Me.ActivityDataGridView.DataSource = Me.ActivityBindingSource
            Me.ActivityDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
            Me.ActivityDataGridView.Location = New System.Drawing.Point(0, 0)
            Me.ActivityDataGridView.Name = "ActivityDataGridView"
            Me.ActivityDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.ActivityDataGridView.Size = New System.Drawing.Size(675, 248)
            Me.ActivityDataGridView.TabIndex = 1
            '
            'DataGridViewTextBoxColumn1
            '
            Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
            Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.Width = 41
            '
            'DataGridViewTextBoxColumn2
            '
            Me.DataGridViewTextBoxColumn2.DataPropertyName = "Type"
            Me.DataGridViewTextBoxColumn2.HeaderText = "Type"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            Me.DataGridViewTextBoxColumn2.Width = 56
            '
            'DataGridViewTextBoxColumn3
            '
            Me.DataGridViewTextBoxColumn3.DataPropertyName = "Status"
            Me.DataGridViewTextBoxColumn3.HeaderText = "Status"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.Width = 62
            '
            'DataGridViewTextBoxColumn4
            '
            Me.DataGridViewTextBoxColumn4.DataPropertyName = "StartDate"
            Me.DataGridViewTextBoxColumn4.HeaderText = "StartDate"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.Width = 77
            '
            'DataGridViewTextBoxColumn5
            '
            Me.DataGridViewTextBoxColumn5.DataPropertyName = "FinishDate"
            Me.DataGridViewTextBoxColumn5.HeaderText = "FinishDate"
            Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
            Me.DataGridViewTextBoxColumn5.Width = 82
            '
            'DataGridViewTextBoxColumn6
            '
            Me.DataGridViewTextBoxColumn6.DataPropertyName = "FileName"
            Me.DataGridViewTextBoxColumn6.HeaderText = "FileName"
            Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
            Me.DataGridViewTextBoxColumn6.Width = 76
            '
            'DataGridViewTextBoxColumn7
            '
            Me.DataGridViewTextBoxColumn7.DataPropertyName = "CreatedDate"
            Me.DataGridViewTextBoxColumn7.HeaderText = "CreatedDate"
            Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
            Me.DataGridViewTextBoxColumn7.Width = 92
            '
            'DataGridViewTextBoxColumn8
            '
            Me.DataGridViewTextBoxColumn8.DataPropertyName = "ErrorCount"
            Me.DataGridViewTextBoxColumn8.HeaderText = "ErrorCount"
            Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
            Me.DataGridViewTextBoxColumn8.Width = 82
            '
            'DataGridViewTextBoxColumn9
            '
            Me.DataGridViewTextBoxColumn9.DataPropertyName = "ContactCount"
            Me.DataGridViewTextBoxColumn9.HeaderText = "ContactCount"
            Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
            Me.DataGridViewTextBoxColumn9.Width = 97
            '
            'DataGridViewTextBoxColumn10
            '
            Me.DataGridViewTextBoxColumn10.DataPropertyName = "Errors"
            Me.DataGridViewTextBoxColumn10.HeaderText = "Errors"
            Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
            Me.DataGridViewTextBoxColumn10.Width = 59
            '
            'DataGridViewTextBoxColumn11
            '
            Me.DataGridViewTextBoxColumn11.DataPropertyName = "Warnings"
            Me.DataGridViewTextBoxColumn11.HeaderText = "Warnings"
            Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
            Me.DataGridViewTextBoxColumn11.Width = 77
            '
            'ActivityBindingSource
            '
            Me.ActivityBindingSource.DataSource = GetType(CTCT.Components.Activities.Activity)
            '
            'ContactCountTextBox
            '
            Me.ContactCountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActivityBindingSource, "ContactCount", True))
            Me.ContactCountTextBox.Enabled = False
            Me.ContactCountTextBox.Location = New System.Drawing.Point(96, 253)
            Me.ContactCountTextBox.Name = "ContactCountTextBox"
            Me.ContactCountTextBox.Size = New System.Drawing.Size(200, 20)
            Me.ContactCountTextBox.TabIndex = 2
            '
            'CreatedDateDateTimePicker
            '
            Me.CreatedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ActivityBindingSource, "CreatedDate", True))
            Me.CreatedDateDateTimePicker.Enabled = False
            Me.CreatedDateDateTimePicker.Location = New System.Drawing.Point(96, 279)
            Me.CreatedDateDateTimePicker.Name = "CreatedDateDateTimePicker"
            Me.CreatedDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
            Me.CreatedDateDateTimePicker.TabIndex = 4
            '
            'ErrorCountTextBox
            '
            Me.ErrorCountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActivityBindingSource, "ErrorCount", True))
            Me.ErrorCountTextBox.Enabled = False
            Me.ErrorCountTextBox.Location = New System.Drawing.Point(96, 305)
            Me.ErrorCountTextBox.Name = "ErrorCountTextBox"
            Me.ErrorCountTextBox.Size = New System.Drawing.Size(200, 20)
            Me.ErrorCountTextBox.TabIndex = 6
            '
            'FileNameTextBox
            '
            Me.FileNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActivityBindingSource, "FileName", True))
            Me.FileNameTextBox.Enabled = False
            Me.FileNameTextBox.Location = New System.Drawing.Point(96, 331)
            Me.FileNameTextBox.Name = "FileNameTextBox"
            Me.FileNameTextBox.Size = New System.Drawing.Size(200, 20)
            Me.FileNameTextBox.TabIndex = 8
            '
            'FinishDateDateTimePicker
            '
            Me.FinishDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ActivityBindingSource, "FinishDate", True))
            Me.FinishDateDateTimePicker.Enabled = False
            Me.FinishDateDateTimePicker.Location = New System.Drawing.Point(96, 357)
            Me.FinishDateDateTimePicker.Name = "FinishDateDateTimePicker"
            Me.FinishDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
            Me.FinishDateDateTimePicker.TabIndex = 10
            '
            'IdTextBox
            '
            Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActivityBindingSource, "Id", True))
            Me.IdTextBox.Enabled = False
            Me.IdTextBox.Location = New System.Drawing.Point(96, 383)
            Me.IdTextBox.Name = "IdTextBox"
            Me.IdTextBox.Size = New System.Drawing.Size(200, 20)
            Me.IdTextBox.TabIndex = 12
            '
            'StartDateDateTimePicker
            '
            Me.StartDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ActivityBindingSource, "StartDate", True))
            Me.StartDateDateTimePicker.Enabled = False
            Me.StartDateDateTimePicker.Location = New System.Drawing.Point(96, 409)
            Me.StartDateDateTimePicker.Name = "StartDateDateTimePicker"
            Me.StartDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
            Me.StartDateDateTimePicker.TabIndex = 14
            '
            'StatusTextBox
            '
            Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActivityBindingSource, "Status", True))
            Me.StatusTextBox.Enabled = False
            Me.StatusTextBox.Location = New System.Drawing.Point(96, 435)
            Me.StatusTextBox.Name = "StatusTextBox"
            Me.StatusTextBox.Size = New System.Drawing.Size(200, 20)
            Me.StatusTextBox.TabIndex = 16
            '
            'TypeTextBox
            '
            Me.TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActivityBindingSource, "Type", True))
            Me.TypeTextBox.Enabled = False
            Me.TypeTextBox.Location = New System.Drawing.Point(96, 461)
            Me.TypeTextBox.Name = "TypeTextBox"
            Me.TypeTextBox.Size = New System.Drawing.Size(200, 20)
            Me.TypeTextBox.TabIndex = 18
            '
            'ErrorsBindingSource
            '
            Me.ErrorsBindingSource.DataMember = "Errors"
            Me.ErrorsBindingSource.DataSource = Me.ActivityBindingSource
            '
            'ErrorsDataGridView
            '
            Me.ErrorsDataGridView.AutoGenerateColumns = False
            Me.ErrorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.ErrorsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
            Me.ErrorsDataGridView.DataSource = Me.ErrorsBindingSource
            Me.ErrorsDataGridView.Location = New System.Drawing.Point(336, 272)
            Me.ErrorsDataGridView.Name = "ErrorsDataGridView"
            Me.ErrorsDataGridView.Size = New System.Drawing.Size(356, 184)
            Me.ErrorsDataGridView.TabIndex = 19
            '
            'DataGridViewTextBoxColumn12
            '
            Me.DataGridViewTextBoxColumn12.DataPropertyName = "Message"
            Me.DataGridViewTextBoxColumn12.HeaderText = "Message"
            Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
            '
            'DataGridViewTextBoxColumn13
            '
            Me.DataGridViewTextBoxColumn13.DataPropertyName = "LineNumber"
            Me.DataGridViewTextBoxColumn13.HeaderText = "LineNumber"
            Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
            '
            'DataGridViewTextBoxColumn14
            '
            Me.DataGridViewTextBoxColumn14.DataPropertyName = "EmailAddress"
            Me.DataGridViewTextBoxColumn14.HeaderText = "EmailAddress"
            Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
            '
            'WarningsBindingSource
            '
            Me.WarningsBindingSource.DataMember = "Warnings"
            Me.WarningsBindingSource.DataSource = Me.ActivityBindingSource
            '
            'ErrorsDataGridView1
            '
            Me.ErrorsDataGridView1.AutoGenerateColumns = False
            Me.ErrorsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.ErrorsDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
            Me.ErrorsDataGridView1.DataSource = Me.WarningsBindingSource
            Me.ErrorsDataGridView1.Location = New System.Drawing.Point(336, 488)
            Me.ErrorsDataGridView1.Name = "ErrorsDataGridView1"
            Me.ErrorsDataGridView1.Size = New System.Drawing.Size(352, 168)
            Me.ErrorsDataGridView1.TabIndex = 20
            '
            'DataGridViewTextBoxColumn15
            '
            Me.DataGridViewTextBoxColumn15.DataPropertyName = "Message"
            Me.DataGridViewTextBoxColumn15.HeaderText = "Message"
            Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
            '
            'DataGridViewTextBoxColumn16
            '
            Me.DataGridViewTextBoxColumn16.DataPropertyName = "LineNumber"
            Me.DataGridViewTextBoxColumn16.HeaderText = "LineNumber"
            Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
            '
            'DataGridViewTextBoxColumn17
            '
            Me.DataGridViewTextBoxColumn17.DataPropertyName = "EmailAddress"
            Me.DataGridViewTextBoxColumn17.HeaderText = "EmailAddress"
            Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(336, 256)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(34, 13)
            Me.Label1.TabIndex = 21
            Me.Label1.Text = "Errors"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(336, 464)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(52, 13)
            Me.Label2.TabIndex = 22
            Me.Label2.Text = "Warnings"
            '
            'ActivityView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.ErrorsDataGridView1)
            Me.Controls.Add(Me.ErrorsDataGridView)
            Me.Controls.Add(ContactCountLabel)
            Me.Controls.Add(Me.ContactCountTextBox)
            Me.Controls.Add(CreatedDateLabel)
            Me.Controls.Add(Me.CreatedDateDateTimePicker)
            Me.Controls.Add(ErrorCountLabel)
            Me.Controls.Add(Me.ErrorCountTextBox)
            Me.Controls.Add(FileNameLabel)
            Me.Controls.Add(Me.FileNameTextBox)
            Me.Controls.Add(FinishDateLabel)
            Me.Controls.Add(Me.FinishDateDateTimePicker)
            Me.Controls.Add(IdLabel)
            Me.Controls.Add(Me.IdTextBox)
            Me.Controls.Add(StartDateLabel)
            Me.Controls.Add(Me.StartDateDateTimePicker)
            Me.Controls.Add(StatusLabel)
            Me.Controls.Add(Me.StatusTextBox)
            Me.Controls.Add(TypeLabel)
            Me.Controls.Add(Me.TypeTextBox)
            Me.Controls.Add(Me.ActivityDataGridView)
            Me.Name = "ActivityView"
            Me.Size = New System.Drawing.Size(696, 664)
            CType(Me.ActivityDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ActivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrorsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.WarningsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrorsDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents ActivityBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents ActivityDataGridView As System.Windows.Forms.DataGridView
        Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ContactCountTextBox As System.Windows.Forms.TextBox
        Friend WithEvents CreatedDateDateTimePicker As System.Windows.Forms.DateTimePicker
        Friend WithEvents ErrorCountTextBox As System.Windows.Forms.TextBox
        Friend WithEvents FileNameTextBox As System.Windows.Forms.TextBox
        Friend WithEvents FinishDateDateTimePicker As System.Windows.Forms.DateTimePicker
        Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
        Friend WithEvents StartDateDateTimePicker As System.Windows.Forms.DateTimePicker
        Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
        Friend WithEvents TypeTextBox As System.Windows.Forms.TextBox
        Friend WithEvents ErrorsBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents ErrorsDataGridView As System.Windows.Forms.DataGridView
        Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents WarningsBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents ErrorsDataGridView1 As System.Windows.Forms.DataGridView
        Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label

    End Class

End Namespace