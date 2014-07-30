namespace MessageLogViewer
{
    partial class MessageLogEntryViewer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageLogEntryViewer));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stackTraceSearchTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.messageSearchTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateRangeCheckBox = new System.Windows.Forms.CheckBox();
            this.errorOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.runSearchButton = new System.Windows.Forms.Button();
            this.dateRangeGroupBox = new System.Windows.Forms.GroupBox();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.databaseList = new System.Windows.Forms.ComboBox();
            this.programComboBox = new System.Windows.Forms.ComboBox();
            this.stationComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.countComboBox = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.databaseNameStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.useridStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.passwordStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.filterStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.recordCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.messageViewer1 = new MessageLogViewer.UI.Controls.MessageViewer();
            this.messageListViewer1 = new MessageLogViewer.UI.Controls.MessageListViewer();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.dateRangeGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 340);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(995, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dateRangeCheckBox);
            this.panel1.Controls.Add(this.errorOnlyCheckBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.employeeComboBox);
            this.panel1.Controls.Add(this.runSearchButton);
            this.panel1.Controls.Add(this.dateRangeGroupBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.databaseList);
            this.panel1.Controls.Add(this.programComboBox);
            this.panel1.Controls.Add(this.stationComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.countComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 170);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stackTraceSearchTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.messageSearchTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(345, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 88);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Searches (Contains)";
            // 
            // stackTraceSearchTextBox
            // 
            this.stackTraceSearchTextBox.Location = new System.Drawing.Point(81, 53);
            this.stackTraceSearchTextBox.Name = "stackTraceSearchTextBox";
            this.stackTraceSearchTextBox.Size = new System.Drawing.Size(302, 20);
            this.stackTraceSearchTextBox.TabIndex = 27;
            this.stackTraceSearchTextBox.TextChanged += new System.EventHandler(this.stackTraceSearchTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Message:";
            // 
            // messageSearchTextBox
            // 
            this.messageSearchTextBox.Location = new System.Drawing.Point(81, 27);
            this.messageSearchTextBox.Name = "messageSearchTextBox";
            this.messageSearchTextBox.Size = new System.Drawing.Size(302, 20);
            this.messageSearchTextBox.TabIndex = 12;
            this.messageSearchTextBox.TextChanged += new System.EventHandler(this.messageSearchTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Stack Trace:";
            // 
            // dateRangeCheckBox
            // 
            this.dateRangeCheckBox.AutoSize = true;
            this.dateRangeCheckBox.Checked = true;
            this.dateRangeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dateRangeCheckBox.Location = new System.Drawing.Point(740, 13);
            this.dateRangeCheckBox.Name = "dateRangeCheckBox";
            this.dateRangeCheckBox.Size = new System.Drawing.Size(154, 17);
            this.dateRangeCheckBox.TabIndex = 21;
            this.dateRangeCheckBox.Text = "Filter Results by Timestamp";
            this.dateRangeCheckBox.UseVisualStyleBackColor = true;
            this.dateRangeCheckBox.CheckedChanged += new System.EventHandler(this.dateRangeCheckBox_CheckedChanged);
            // 
            // errorOnlyCheckBox
            // 
            this.errorOnlyCheckBox.AutoSize = true;
            this.errorOnlyCheckBox.Location = new System.Drawing.Point(605, 14);
            this.errorOnlyCheckBox.Name = "errorOnlyCheckBox";
            this.errorOnlyCheckBox.Size = new System.Drawing.Size(123, 17);
            this.errorOnlyCheckBox.TabIndex = 25;
            this.errorOnlyCheckBox.Text = "Error Messages Only";
            this.errorOnlyCheckBox.UseVisualStyleBackColor = true;
            this.errorOnlyCheckBox.CheckedChanged += new System.EventHandler(this.errorOnlyCheckBox_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Employee #:";
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(255, 41);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(75, 21);
            this.employeeComboBox.TabIndex = 23;
            this.employeeComboBox.SelectedIndexChanged += new System.EventHandler(this.employeeComboBox_SelectedIndexChanged);
            // 
            // runSearchButton
            // 
            this.runSearchButton.Location = new System.Drawing.Point(908, 135);
            this.runSearchButton.Name = "runSearchButton";
            this.runSearchButton.Size = new System.Drawing.Size(75, 23);
            this.runSearchButton.TabIndex = 22;
            this.runSearchButton.Text = "Search";
            this.runSearchButton.UseVisualStyleBackColor = true;
            this.runSearchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dateRangeGroupBox
            // 
            this.dateRangeGroupBox.Controls.Add(this.endDateTimePicker);
            this.dateRangeGroupBox.Controls.Add(this.label7);
            this.dateRangeGroupBox.Controls.Add(this.startDateTimePicker);
            this.dateRangeGroupBox.Controls.Add(this.label6);
            this.dateRangeGroupBox.Location = new System.Drawing.Point(740, 41);
            this.dateRangeGroupBox.Name = "dateRangeGroupBox";
            this.dateRangeGroupBox.Size = new System.Drawing.Size(252, 88);
            this.dateRangeGroupBox.TabIndex = 21;
            this.dateRangeGroupBox.TabStop = false;
            this.dateRangeGroupBox.Text = "Timestamp Range";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Enabled = false;
            this.endDateTimePicker.Location = new System.Drawing.Point(40, 53);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.endDateTimePicker.TabIndex = 18;
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.endDateTimePicker_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "End";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Enabled = false;
            this.startDateTimePicker.Location = new System.Drawing.Point(40, 27);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.startDateTimePicker.TabIndex = 17;
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.startDateTimePicker_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Program:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Station #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Database:";
            // 
            // databaseList
            // 
            this.databaseList.FormattingEnabled = true;
            this.databaseList.Items.AddRange(new object[] {
            "10",
            "100",
            "25",
            "50",
            "All"});
            this.databaseList.Location = new System.Drawing.Point(71, 11);
            this.databaseList.Name = "databaseList";
            this.databaseList.Size = new System.Drawing.Size(259, 21);
            this.databaseList.Sorted = true;
            this.databaseList.TabIndex = 7;
            this.databaseList.SelectedIndexChanged += new System.EventHandler(this.databaseList_SelectedIndexChanged);
            // 
            // programComboBox
            // 
            this.programComboBox.FormattingEnabled = true;
            this.programComboBox.Location = new System.Drawing.Point(71, 68);
            this.programComboBox.Name = "programComboBox";
            this.programComboBox.Size = new System.Drawing.Size(259, 21);
            this.programComboBox.TabIndex = 6;
            this.programComboBox.SelectedIndexChanged += new System.EventHandler(this.programComboBox_SelectedIndexChanged);
            // 
            // stationComboBox
            // 
            this.stationComboBox.FormattingEnabled = true;
            this.stationComboBox.Location = new System.Drawing.Point(71, 41);
            this.stationComboBox.Name = "stationComboBox";
            this.stationComboBox.Size = new System.Drawing.Size(75, 21);
            this.stationComboBox.TabIndex = 5;
            this.stationComboBox.SelectedIndexChanged += new System.EventHandler(this.stationComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max Count:";
            // 
            // countComboBox
            // 
            this.countComboBox.FormattingEnabled = true;
            this.countComboBox.Items.AddRange(new object[] {
            "All",
            "10",
            "25",
            "50",
            "100"});
            this.countComboBox.Location = new System.Drawing.Point(428, 11);
            this.countComboBox.Name = "countComboBox";
            this.countComboBox.Size = new System.Drawing.Size(73, 21);
            this.countComboBox.TabIndex = 1;
            this.countComboBox.SelectedIndexChanged += new System.EventHandler(this.countComboBox_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseNameStatusLabel,
            this.useridStatusLabel,
            this.passwordStatusLabel,
            this.filterStatusLabel,
            this.recordCountStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 693);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(995, 24);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // databaseNameStatusLabel
            // 
            this.databaseNameStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.databaseNameStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.databaseNameStatusLabel.Name = "databaseNameStatusLabel";
            this.databaseNameStatusLabel.Size = new System.Drawing.Size(58, 19);
            this.databaseNameStatusLabel.Text = "database";
            // 
            // useridStatusLabel
            // 
            this.useridStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.useridStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.useridStatusLabel.Name = "useridStatusLabel";
            this.useridStatusLabel.Size = new System.Drawing.Size(43, 19);
            this.useridStatusLabel.Text = "userid";
            // 
            // passwordStatusLabel
            // 
            this.passwordStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.passwordStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.passwordStatusLabel.Name = "passwordStatusLabel";
            this.passwordStatusLabel.Size = new System.Drawing.Size(61, 19);
            this.passwordStatusLabel.Text = "password";
            // 
            // filterStatusLabel
            // 
            this.filterStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.filterStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.filterStatusLabel.Name = "filterStatusLabel";
            this.filterStatusLabel.Size = new System.Drawing.Size(742, 19);
            this.filterStatusLabel.Spring = true;
            this.filterStatusLabel.Text = "Filter: ~";
            this.filterStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // recordCountStatusLabel
            // 
            this.recordCountStatusLabel.BackColor = System.Drawing.SystemColors.Info;
            this.recordCountStatusLabel.Name = "recordCountStatusLabel";
            this.recordCountStatusLabel.Size = new System.Drawing.Size(76, 19);
            this.recordCountStatusLabel.Text = "[No Records]";
            // 
            // messageViewer1
            // 
            this.messageViewer1.BackColor = System.Drawing.Color.SteelBlue;
            this.messageViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageViewer1.Location = new System.Drawing.Point(0, 343);
            this.messageViewer1.Name = "messageViewer1";
            this.messageViewer1.Size = new System.Drawing.Size(995, 374);
            this.messageViewer1.TabIndex = 4;
            // 
            // messageListViewer1
            // 
            this.messageListViewer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.messageListViewer1.Location = new System.Drawing.Point(0, 170);
            this.messageListViewer1.Name = "messageListViewer1";
            this.messageListViewer1.Size = new System.Drawing.Size(995, 170);
            this.messageListViewer1.TabIndex = 0;
            // 
            // MessageLogEntryViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 717);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.messageViewer1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.messageListViewer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageLogEntryViewer";
            this.Text = "MessageLog Viewer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.dateRangeGroupBox.ResumeLayout(false);
            this.dateRangeGroupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.Controls.MessageListViewer messageListViewer1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox countComboBox;
        private System.Windows.Forms.ComboBox programComboBox;
        private System.Windows.Forms.ComboBox stationComboBox;
        private UI.Controls.MessageViewer messageViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox databaseList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel databaseNameStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel useridStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel passwordStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel filterStatusLabel;
        private System.Windows.Forms.TextBox messageSearchTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.GroupBox dateRangeGroupBox;
        private System.Windows.Forms.CheckBox dateRangeCheckBox;
        private System.Windows.Forms.Button runSearchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox stackTraceSearchTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox errorOnlyCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.ToolStripStatusLabel recordCountStatusLabel;
    }
}

