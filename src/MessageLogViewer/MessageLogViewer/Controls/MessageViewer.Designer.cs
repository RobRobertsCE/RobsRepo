namespace MessageLogViewer.UI.Controls
{
    partial class MessageViewer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label employeeNumberLabel;
            System.Windows.Forms.Label errorMessageLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label messageLabel;
            System.Windows.Forms.Label programNameLabel;
            System.Windows.Forms.Label stackTraceLabel;
            System.Windows.Forms.Label timestampLabel;
            System.Windows.Forms.Label stationNoLabel;
            this.employeeNumberTextBox = new System.Windows.Forms.TextBox();
            this.errorMessageCheckBox = new System.Windows.Forms.CheckBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.programNameTextBox = new System.Windows.Forms.TextBox();
            this.stackTraceTextBox = new System.Windows.Forms.TextBox();
            this.timestampDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.stationNoTextBox = new System.Windows.Forms.TextBox();
            this.copyMessageButton = new System.Windows.Forms.Button();
            this.copyStackTraceButton = new System.Windows.Forms.Button();
            this.copyAllButton = new System.Windows.Forms.Button();
            this.hidden = new System.Windows.Forms.TextBox();
            this.messageLogEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            employeeNumberLabel = new System.Windows.Forms.Label();
            errorMessageLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            programNameLabel = new System.Windows.Forms.Label();
            stackTraceLabel = new System.Windows.Forms.Label();
            timestampLabel = new System.Windows.Forms.Label();
            stationNoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.messageLogEntryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeNumberLabel
            // 
            employeeNumberLabel.AutoSize = true;
            employeeNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeNumberLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            employeeNumberLabel.Location = new System.Drawing.Point(583, 43);
            employeeNumberLabel.Name = "employeeNumberLabel";
            employeeNumberLabel.Size = new System.Drawing.Size(65, 13);
            employeeNumberLabel.TabIndex = 3;
            employeeNumberLabel.Text = "Employee:";
            // 
            // errorMessageLabel
            // 
            errorMessageLabel.AutoSize = true;
            errorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            errorMessageLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            errorMessageLabel.Location = new System.Drawing.Point(454, 12);
            errorMessageLabel.Name = "errorMessageLabel";
            errorMessageLabel.Size = new System.Drawing.Size(92, 13);
            errorMessageLabel.TabIndex = 5;
            errorMessageLabel.Text = "Error Message:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            iDLabel.Location = new System.Drawing.Point(74, 10);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(24, 13);
            iDLabel.TabIndex = 7;
            iDLabel.Text = "ID:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            messageLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            messageLabel.Location = new System.Drawing.Point(37, 74);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(61, 13);
            messageLabel.TabIndex = 9;
            messageLabel.Text = "Message:";
            // 
            // programNameLabel
            // 
            programNameLabel.AutoSize = true;
            programNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            programNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            programNameLabel.Location = new System.Drawing.Point(5, 43);
            programNameLabel.Name = "programNameLabel";
            programNameLabel.Size = new System.Drawing.Size(93, 13);
            programNameLabel.TabIndex = 11;
            programNameLabel.Text = "Program Name:";
            // 
            // stackTraceLabel
            // 
            stackTraceLabel.AutoSize = true;
            stackTraceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stackTraceLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            stackTraceLabel.Location = new System.Drawing.Point(17, 169);
            stackTraceLabel.Name = "stackTraceLabel";
            stackTraceLabel.Size = new System.Drawing.Size(81, 13);
            stackTraceLabel.TabIndex = 13;
            stackTraceLabel.Text = "Stack Trace:";
            // 
            // timestampLabel
            // 
            timestampLabel.AutoSize = true;
            timestampLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            timestampLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            timestampLabel.Location = new System.Drawing.Point(576, 10);
            timestampLabel.Name = "timestampLabel";
            timestampLabel.Size = new System.Drawing.Size(71, 13);
            timestampLabel.TabIndex = 15;
            timestampLabel.Text = "Timestamp:";
            // 
            // stationNoLabel
            // 
            stationNoLabel.AutoSize = true;
            stationNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stationNoLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            stationNoLabel.Location = new System.Drawing.Point(427, 43);
            stationNoLabel.Name = "stationNoLabel";
            stationNoLabel.Size = new System.Drawing.Size(51, 13);
            stationNoLabel.TabIndex = 19;
            stationNoLabel.Text = "Station:";
            // 
            // employeeNumberTextBox
            // 
            this.employeeNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messageLogEntryBindingSource, "EmployeeNumber", true));
            this.employeeNumberTextBox.Location = new System.Drawing.Point(654, 39);
            this.employeeNumberTextBox.Name = "employeeNumberTextBox";
            this.employeeNumberTextBox.ReadOnly = true;
            this.employeeNumberTextBox.Size = new System.Drawing.Size(78, 20);
            this.employeeNumberTextBox.TabIndex = 4;
            // 
            // errorMessageCheckBox
            // 
            this.errorMessageCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.messageLogEntryBindingSource, "ErrorMessage", true));
            this.errorMessageCheckBox.Enabled = false;
            this.errorMessageCheckBox.Location = new System.Drawing.Point(552, 6);
            this.errorMessageCheckBox.Name = "errorMessageCheckBox";
            this.errorMessageCheckBox.Size = new System.Drawing.Size(10, 24);
            this.errorMessageCheckBox.TabIndex = 6;
            this.errorMessageCheckBox.UseVisualStyleBackColor = true;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messageLogEntryBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(105, 6);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(318, 20);
            this.iDTextBox.TabIndex = 8;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messageLogEntryBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(104, 71);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageTextBox.Size = new System.Drawing.Size(821, 80);
            this.messageTextBox.TabIndex = 10;
            // 
            // programNameTextBox
            // 
            this.programNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messageLogEntryBindingSource, "ProgramName", true));
            this.programNameTextBox.Location = new System.Drawing.Point(105, 39);
            this.programNameTextBox.Name = "programNameTextBox";
            this.programNameTextBox.ReadOnly = true;
            this.programNameTextBox.Size = new System.Drawing.Size(318, 20);
            this.programNameTextBox.TabIndex = 12;
            // 
            // stackTraceTextBox
            // 
            this.stackTraceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stackTraceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messageLogEntryBindingSource, "StackTrace", true));
            this.stackTraceTextBox.Location = new System.Drawing.Point(104, 166);
            this.stackTraceTextBox.Multiline = true;
            this.stackTraceTextBox.Name = "stackTraceTextBox";
            this.stackTraceTextBox.ReadOnly = true;
            this.stackTraceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.stackTraceTextBox.Size = new System.Drawing.Size(821, 134);
            this.stackTraceTextBox.TabIndex = 14;
            // 
            // timestampDateTimePicker
            // 
            this.timestampDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.messageLogEntryBindingSource, "Timestamp", true));
            this.timestampDateTimePicker.Enabled = false;
            this.timestampDateTimePicker.Location = new System.Drawing.Point(654, 6);
            this.timestampDateTimePicker.Name = "timestampDateTimePicker";
            this.timestampDateTimePicker.Size = new System.Drawing.Size(244, 20);
            this.timestampDateTimePicker.TabIndex = 16;
            // 
            // stationNoTextBox
            // 
            this.stationNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messageLogEntryBindingSource, "Station", true));
            this.stationNoTextBox.Location = new System.Drawing.Point(482, 39);
            this.stationNoTextBox.Name = "stationNoTextBox";
            this.stationNoTextBox.ReadOnly = true;
            this.stationNoTextBox.Size = new System.Drawing.Size(78, 20);
            this.stationNoTextBox.TabIndex = 20;
            // 
            // copyMessageButton
            // 
            this.copyMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyMessageButton.Location = new System.Drawing.Point(8, 128);
            this.copyMessageButton.Name = "copyMessageButton";
            this.copyMessageButton.Size = new System.Drawing.Size(90, 23);
            this.copyMessageButton.TabIndex = 21;
            this.copyMessageButton.Text = "Copy Message";
            this.copyMessageButton.UseVisualStyleBackColor = true;
            this.copyMessageButton.Click += new System.EventHandler(this.copyMessageButton_Click);
            // 
            // copyStackTraceButton
            // 
            this.copyStackTraceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyStackTraceButton.Location = new System.Drawing.Point(8, 276);
            this.copyStackTraceButton.Name = "copyStackTraceButton";
            this.copyStackTraceButton.Size = new System.Drawing.Size(90, 23);
            this.copyStackTraceButton.TabIndex = 22;
            this.copyStackTraceButton.Text = "Copy Trace";
            this.copyStackTraceButton.UseVisualStyleBackColor = true;
            this.copyStackTraceButton.Click += new System.EventHandler(this.copyStackTraceButton_Click);
            // 
            // copyAllButton
            // 
            this.copyAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copyAllButton.Location = new System.Drawing.Point(803, 306);
            this.copyAllButton.Name = "copyAllButton";
            this.copyAllButton.Size = new System.Drawing.Size(122, 30);
            this.copyAllButton.TabIndex = 23;
            this.copyAllButton.Text = "Copy All";
            this.copyAllButton.UseVisualStyleBackColor = true;
            this.copyAllButton.Click += new System.EventHandler(this.copyAllButton_Click);
            // 
            // hidden
            // 
            this.hidden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hidden.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messageLogEntryBindingSource, "StackTrace", true));
            this.hidden.Location = new System.Drawing.Point(104, 306);
            this.hidden.Multiline = true;
            this.hidden.Name = "hidden";
            this.hidden.ReadOnly = true;
            this.hidden.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.hidden.Size = new System.Drawing.Size(275, 17);
            this.hidden.TabIndex = 24;
            this.hidden.Visible = false;
            // 
            // messageLogEntryBindingSource
            // 
            this.messageLogEntryBindingSource.DataSource = typeof(MessageLog.Business.MessageLogEntry);
            // 
            // MessageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.copyAllButton);
            this.Controls.Add(this.hidden);
            this.Controls.Add(this.copyStackTraceButton);
            this.Controls.Add(this.copyMessageButton);
            this.Controls.Add(stationNoLabel);
            this.Controls.Add(this.stationNoTextBox);
            this.Controls.Add(employeeNumberLabel);
            this.Controls.Add(this.employeeNumberTextBox);
            this.Controls.Add(errorMessageLabel);
            this.Controls.Add(this.errorMessageCheckBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(messageLabel);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(programNameLabel);
            this.Controls.Add(this.programNameTextBox);
            this.Controls.Add(stackTraceLabel);
            this.Controls.Add(this.stackTraceTextBox);
            this.Controls.Add(timestampLabel);
            this.Controls.Add(this.timestampDateTimePicker);
            this.Name = "MessageViewer";
            this.Size = new System.Drawing.Size(941, 381);
            ((System.ComponentModel.ISupportInitialize)(this.messageLogEntryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.BindingSource messageLogEntryBindingSource;
        private System.Windows.Forms.TextBox employeeNumberTextBox;
        private System.Windows.Forms.CheckBox errorMessageCheckBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox programNameTextBox;
        private System.Windows.Forms.TextBox stackTraceTextBox;
        private System.Windows.Forms.DateTimePicker timestampDateTimePicker;
        private System.Windows.Forms.TextBox stationNoTextBox;
        private System.Windows.Forms.Button copyMessageButton;
        private System.Windows.Forms.Button copyStackTraceButton;
        private System.Windows.Forms.Button copyAllButton;
        private System.Windows.Forms.TextBox hidden;
    }
}
