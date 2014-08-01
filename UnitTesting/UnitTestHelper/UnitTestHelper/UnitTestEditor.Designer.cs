namespace UnitTestHelper
{
    partial class UnitTestEditor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAssemblyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelsListBox = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.generateCodeButton = new System.Windows.Forms.Button();
            this.codeTabControl = new System.Windows.Forms.TabControl();
            this.validationTabPage = new System.Windows.Forms.TabPage();
            this.testTabPage = new System.Windows.Forms.TabPage();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.testTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.codeTabControl.SuspendLayout();
            this.validationTabPage.SuspendLayout();
            this.testTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAssemblyToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openAssemblyToolStripMenuItem
            // 
            this.openAssemblyToolStripMenuItem.Name = "openAssemblyToolStripMenuItem";
            this.openAssemblyToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.openAssemblyToolStripMenuItem.Text = "Open Assembly";
            this.openAssemblyToolStripMenuItem.Click += new System.EventHandler(this.openAssemblyToolStripMenuItem_Click);
            // 
            // modelsListBox
            // 
            this.modelsListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.modelsListBox.FormattingEnabled = true;
            this.modelsListBox.Location = new System.Drawing.Point(0, 24);
            this.modelsListBox.Name = "modelsListBox";
            this.modelsListBox.Size = new System.Drawing.Size(216, 443);
            this.modelsListBox.TabIndex = 1;
            this.modelsListBox.SelectedIndexChanged += new System.EventHandler(this.modelsListBox_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(216, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 443);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.generateCodeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(219, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 48);
            this.panel1.TabIndex = 3;
            // 
            // generateCodeButton
            // 
            this.generateCodeButton.Enabled = false;
            this.generateCodeButton.Location = new System.Drawing.Point(8, 8);
            this.generateCodeButton.Name = "generateCodeButton";
            this.generateCodeButton.Size = new System.Drawing.Size(112, 23);
            this.generateCodeButton.TabIndex = 0;
            this.generateCodeButton.Text = "Generate Code";
            this.generateCodeButton.UseVisualStyleBackColor = true;
            this.generateCodeButton.Click += new System.EventHandler(this.generateCodeButton_Click);
            // 
            // codeTabControl
            // 
            this.codeTabControl.Controls.Add(this.validationTabPage);
            this.codeTabControl.Controls.Add(this.testTabPage);
            this.codeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeTabControl.Location = new System.Drawing.Point(219, 72);
            this.codeTabControl.Name = "codeTabControl";
            this.codeTabControl.SelectedIndex = 0;
            this.codeTabControl.Size = new System.Drawing.Size(595, 395);
            this.codeTabControl.TabIndex = 4;
            // 
            // validationTabPage
            // 
            this.validationTabPage.BackColor = System.Drawing.Color.DarkGray;
            this.validationTabPage.Controls.Add(this.codeTextBox);
            this.validationTabPage.Location = new System.Drawing.Point(4, 22);
            this.validationTabPage.Name = "validationTabPage";
            this.validationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.validationTabPage.Size = new System.Drawing.Size(587, 369);
            this.validationTabPage.TabIndex = 0;
            this.validationTabPage.Text = "Validation Code";
            // 
            // testTabPage
            // 
            this.testTabPage.BackColor = System.Drawing.Color.Khaki;
            this.testTabPage.Controls.Add(this.testTextBox);
            this.testTabPage.Location = new System.Drawing.Point(4, 22);
            this.testTabPage.Name = "testTabPage";
            this.testTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.testTabPage.Size = new System.Drawing.Size(587, 369);
            this.testTabPage.TabIndex = 1;
            this.testTabPage.Text = "Unit Tests";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeTextBox.Location = new System.Drawing.Point(8, 32);
            this.codeTextBox.Multiline = true;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.codeTextBox.Size = new System.Drawing.Size(568, 328);
            this.codeTextBox.TabIndex = 0;
            // 
            // testTextBox
            // 
            this.testTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testTextBox.Location = new System.Drawing.Point(8, 40);
            this.testTextBox.Multiline = true;
            this.testTextBox.Name = "testTextBox";
            this.testTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.testTextBox.Size = new System.Drawing.Size(576, 320);
            this.testTextBox.TabIndex = 1;
            // 
            // UnitTestEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 467);
            this.Controls.Add(this.codeTabControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.modelsListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UnitTestEditor";
            this.Text = "UnitTest Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.codeTabControl.ResumeLayout(false);
            this.validationTabPage.ResumeLayout(false);
            this.validationTabPage.PerformLayout();
            this.testTabPage.ResumeLayout(false);
            this.testTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAssemblyToolStripMenuItem;
        private System.Windows.Forms.ListBox modelsListBox;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button generateCodeButton;
        private System.Windows.Forms.TabControl codeTabControl;
        private System.Windows.Forms.TabPage validationTabPage;
        private System.Windows.Forms.TabPage testTabPage;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox testTextBox;
    }
}

