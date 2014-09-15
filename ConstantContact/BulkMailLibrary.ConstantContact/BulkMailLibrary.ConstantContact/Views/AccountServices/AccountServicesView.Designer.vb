Namespace Views.AccountServices

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class AccountServicesView
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
            Dim CountryCodeLabel As System.Windows.Forms.Label
            Dim EmailLabel As System.Windows.Forms.Label
            Dim FirstNameLabel As System.Windows.Forms.Label
            Dim LastNameLabel As System.Windows.Forms.Label
            Dim OrganizationNameLabel As System.Windows.Forms.Label
            Dim PhoneLabel As System.Windows.Forms.Label
            Dim StateCodeLabel As System.Windows.Forms.Label
            Dim TimeZoneLabel As System.Windows.Forms.Label
            Dim WebsiteLabel As System.Windows.Forms.Label
            Dim ApiKeyLabel As System.Windows.Forms.Label
            Me.AccountSummaryInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.CountryCodeTextBox = New System.Windows.Forms.TextBox()
            Me.EmailTextBox = New System.Windows.Forms.TextBox()
            Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
            Me.LastNameTextBox = New System.Windows.Forms.TextBox()
            Me.OrganizationNameTextBox = New System.Windows.Forms.TextBox()
            Me.PhoneTextBox = New System.Windows.Forms.TextBox()
            Me.StateCodeTextBox = New System.Windows.Forms.TextBox()
            Me.TimeZoneTextBox = New System.Windows.Forms.TextBox()
            Me.WebsiteTextBox = New System.Windows.Forms.TextBox()
            Me.SaveButton = New System.Windows.Forms.Button()
            Me.ApiKeyTextBox = New System.Windows.Forms.TextBox()
            CountryCodeLabel = New System.Windows.Forms.Label()
            EmailLabel = New System.Windows.Forms.Label()
            FirstNameLabel = New System.Windows.Forms.Label()
            LastNameLabel = New System.Windows.Forms.Label()
            OrganizationNameLabel = New System.Windows.Forms.Label()
            PhoneLabel = New System.Windows.Forms.Label()
            StateCodeLabel = New System.Windows.Forms.Label()
            TimeZoneLabel = New System.Windows.Forms.Label()
            WebsiteLabel = New System.Windows.Forms.Label()
            ApiKeyLabel = New System.Windows.Forms.Label()
            CType(Me.AccountSummaryInformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'CountryCodeLabel
            '
            CountryCodeLabel.AutoSize = True
            CountryCodeLabel.Location = New System.Drawing.Point(16, 16)
            CountryCodeLabel.Name = "CountryCodeLabel"
            CountryCodeLabel.Size = New System.Drawing.Size(74, 13)
            CountryCodeLabel.TabIndex = 1
            CountryCodeLabel.Text = "Country Code:"
            '
            'EmailLabel
            '
            EmailLabel.AutoSize = True
            EmailLabel.Location = New System.Drawing.Point(16, 42)
            EmailLabel.Name = "EmailLabel"
            EmailLabel.Size = New System.Drawing.Size(35, 13)
            EmailLabel.TabIndex = 3
            EmailLabel.Text = "Email:"
            '
            'FirstNameLabel
            '
            FirstNameLabel.AutoSize = True
            FirstNameLabel.Location = New System.Drawing.Point(16, 68)
            FirstNameLabel.Name = "FirstNameLabel"
            FirstNameLabel.Size = New System.Drawing.Size(60, 13)
            FirstNameLabel.TabIndex = 5
            FirstNameLabel.Text = "First Name:"
            '
            'LastNameLabel
            '
            LastNameLabel.AutoSize = True
            LastNameLabel.Location = New System.Drawing.Point(16, 94)
            LastNameLabel.Name = "LastNameLabel"
            LastNameLabel.Size = New System.Drawing.Size(61, 13)
            LastNameLabel.TabIndex = 7
            LastNameLabel.Text = "Last Name:"
            '
            'OrganizationNameLabel
            '
            OrganizationNameLabel.AutoSize = True
            OrganizationNameLabel.Location = New System.Drawing.Point(16, 120)
            OrganizationNameLabel.Name = "OrganizationNameLabel"
            OrganizationNameLabel.Size = New System.Drawing.Size(100, 13)
            OrganizationNameLabel.TabIndex = 9
            OrganizationNameLabel.Text = "Organization Name:"
            '
            'PhoneLabel
            '
            PhoneLabel.AutoSize = True
            PhoneLabel.Location = New System.Drawing.Point(16, 146)
            PhoneLabel.Name = "PhoneLabel"
            PhoneLabel.Size = New System.Drawing.Size(41, 13)
            PhoneLabel.TabIndex = 11
            PhoneLabel.Text = "Phone:"
            '
            'StateCodeLabel
            '
            StateCodeLabel.AutoSize = True
            StateCodeLabel.Location = New System.Drawing.Point(16, 172)
            StateCodeLabel.Name = "StateCodeLabel"
            StateCodeLabel.Size = New System.Drawing.Size(63, 13)
            StateCodeLabel.TabIndex = 13
            StateCodeLabel.Text = "State Code:"
            '
            'TimeZoneLabel
            '
            TimeZoneLabel.AutoSize = True
            TimeZoneLabel.Location = New System.Drawing.Point(16, 198)
            TimeZoneLabel.Name = "TimeZoneLabel"
            TimeZoneLabel.Size = New System.Drawing.Size(61, 13)
            TimeZoneLabel.TabIndex = 15
            TimeZoneLabel.Text = "Time Zone:"
            '
            'WebsiteLabel
            '
            WebsiteLabel.AutoSize = True
            WebsiteLabel.Location = New System.Drawing.Point(16, 224)
            WebsiteLabel.Name = "WebsiteLabel"
            WebsiteLabel.Size = New System.Drawing.Size(49, 13)
            WebsiteLabel.TabIndex = 17
            WebsiteLabel.Text = "Website:"
            '
            'ApiKeyLabel
            '
            ApiKeyLabel.AutoSize = True
            ApiKeyLabel.Location = New System.Drawing.Point(16, 251)
            ApiKeyLabel.Name = "ApiKeyLabel"
            ApiKeyLabel.Size = New System.Drawing.Size(48, 13)
            ApiKeyLabel.TabIndex = 20
            ApiKeyLabel.Text = "API Key:"
            '
            'AccountSummaryInformationBindingSource
            '
            Me.AccountSummaryInformationBindingSource.AllowNew = True
            Me.AccountSummaryInformationBindingSource.DataSource = GetType(CTCT.Components.AccountService.AccountSummaryInformation)
            '
            'CountryCodeTextBox
            '
            Me.CountryCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountSummaryInformationBindingSource, "CountryCode", True))
            Me.CountryCodeTextBox.Location = New System.Drawing.Point(128, 13)
            Me.CountryCodeTextBox.Name = "CountryCodeTextBox"
            Me.CountryCodeTextBox.Size = New System.Drawing.Size(384, 20)
            Me.CountryCodeTextBox.TabIndex = 2
            '
            'EmailTextBox
            '
            Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountSummaryInformationBindingSource, "Email", True))
            Me.EmailTextBox.Location = New System.Drawing.Point(128, 39)
            Me.EmailTextBox.Name = "EmailTextBox"
            Me.EmailTextBox.Size = New System.Drawing.Size(384, 20)
            Me.EmailTextBox.TabIndex = 4
            '
            'FirstNameTextBox
            '
            Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountSummaryInformationBindingSource, "FirstName", True))
            Me.FirstNameTextBox.Location = New System.Drawing.Point(128, 65)
            Me.FirstNameTextBox.Name = "FirstNameTextBox"
            Me.FirstNameTextBox.Size = New System.Drawing.Size(384, 20)
            Me.FirstNameTextBox.TabIndex = 6
            '
            'LastNameTextBox
            '
            Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountSummaryInformationBindingSource, "LastName", True))
            Me.LastNameTextBox.Location = New System.Drawing.Point(128, 91)
            Me.LastNameTextBox.Name = "LastNameTextBox"
            Me.LastNameTextBox.Size = New System.Drawing.Size(384, 20)
            Me.LastNameTextBox.TabIndex = 8
            '
            'OrganizationNameTextBox
            '
            Me.OrganizationNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountSummaryInformationBindingSource, "OrganizationName", True))
            Me.OrganizationNameTextBox.Location = New System.Drawing.Point(128, 117)
            Me.OrganizationNameTextBox.Name = "OrganizationNameTextBox"
            Me.OrganizationNameTextBox.Size = New System.Drawing.Size(384, 20)
            Me.OrganizationNameTextBox.TabIndex = 10
            '
            'PhoneTextBox
            '
            Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountSummaryInformationBindingSource, "Phone", True))
            Me.PhoneTextBox.Location = New System.Drawing.Point(128, 143)
            Me.PhoneTextBox.Name = "PhoneTextBox"
            Me.PhoneTextBox.Size = New System.Drawing.Size(384, 20)
            Me.PhoneTextBox.TabIndex = 12
            '
            'StateCodeTextBox
            '
            Me.StateCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountSummaryInformationBindingSource, "StateCode", True))
            Me.StateCodeTextBox.Location = New System.Drawing.Point(128, 169)
            Me.StateCodeTextBox.Name = "StateCodeTextBox"
            Me.StateCodeTextBox.Size = New System.Drawing.Size(384, 20)
            Me.StateCodeTextBox.TabIndex = 14
            '
            'TimeZoneTextBox
            '
            Me.TimeZoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountSummaryInformationBindingSource, "TimeZone", True))
            Me.TimeZoneTextBox.Location = New System.Drawing.Point(128, 195)
            Me.TimeZoneTextBox.Name = "TimeZoneTextBox"
            Me.TimeZoneTextBox.Size = New System.Drawing.Size(384, 20)
            Me.TimeZoneTextBox.TabIndex = 16
            '
            'WebsiteTextBox
            '
            Me.WebsiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountSummaryInformationBindingSource, "Website", True))
            Me.WebsiteTextBox.Location = New System.Drawing.Point(128, 221)
            Me.WebsiteTextBox.Name = "WebsiteTextBox"
            Me.WebsiteTextBox.Size = New System.Drawing.Size(384, 20)
            Me.WebsiteTextBox.TabIndex = 18
            '
            'SaveButton
            '
            Me.SaveButton.Location = New System.Drawing.Point(432, 288)
            Me.SaveButton.Name = "SaveButton"
            Me.SaveButton.Size = New System.Drawing.Size(75, 23)
            Me.SaveButton.TabIndex = 19
            Me.SaveButton.Text = "Save"
            Me.SaveButton.UseVisualStyleBackColor = True
            '
            'ApiKeyTextBox
            '
            Me.ApiKeyTextBox.Location = New System.Drawing.Point(128, 248)
            Me.ApiKeyTextBox.Name = "ApiKeyTextBox"
            Me.ApiKeyTextBox.ReadOnly = True
            Me.ApiKeyTextBox.Size = New System.Drawing.Size(384, 20)
            Me.ApiKeyTextBox.TabIndex = 21
            '
            'AccountServicesControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(ApiKeyLabel)
            Me.Controls.Add(Me.ApiKeyTextBox)
            Me.Controls.Add(Me.SaveButton)
            Me.Controls.Add(CountryCodeLabel)
            Me.Controls.Add(Me.CountryCodeTextBox)
            Me.Controls.Add(EmailLabel)
            Me.Controls.Add(Me.EmailTextBox)
            Me.Controls.Add(FirstNameLabel)
            Me.Controls.Add(Me.FirstNameTextBox)
            Me.Controls.Add(LastNameLabel)
            Me.Controls.Add(Me.LastNameTextBox)
            Me.Controls.Add(OrganizationNameLabel)
            Me.Controls.Add(Me.OrganizationNameTextBox)
            Me.Controls.Add(PhoneLabel)
            Me.Controls.Add(Me.PhoneTextBox)
            Me.Controls.Add(StateCodeLabel)
            Me.Controls.Add(Me.StateCodeTextBox)
            Me.Controls.Add(TimeZoneLabel)
            Me.Controls.Add(Me.TimeZoneTextBox)
            Me.Controls.Add(WebsiteLabel)
            Me.Controls.Add(Me.WebsiteTextBox)
            Me.Name = "AccountServicesControl"
            Me.Size = New System.Drawing.Size(560, 318)
            CType(Me.AccountSummaryInformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents AccountSummaryInformationBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents CountryCodeTextBox As System.Windows.Forms.TextBox
        Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
        Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
        Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
        Friend WithEvents OrganizationNameTextBox As System.Windows.Forms.TextBox
        Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
        Friend WithEvents StateCodeTextBox As System.Windows.Forms.TextBox
        Friend WithEvents TimeZoneTextBox As System.Windows.Forms.TextBox
        Friend WithEvents WebsiteTextBox As System.Windows.Forms.TextBox
        Friend WithEvents SaveButton As System.Windows.Forms.Button
        Friend WithEvents ApiKeyTextBox As System.Windows.Forms.TextBox

    End Class

End Namespace