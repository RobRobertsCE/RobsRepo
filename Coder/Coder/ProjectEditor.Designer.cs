namespace Coder
{
    partial class ProjectEditor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dataTypeLabel;
            System.Windows.Forms.Label isForeignKeyLabel;
            System.Windows.Forms.Label primaryKeyLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectEditor));
            this.BusinessModelPanel = new System.Windows.Forms.Panel();
            this.nullableCheckBox = new System.Windows.Forms.CheckBox();
            this.businessModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.modelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foreignKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.primaryKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.modelsListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBusinessModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newModelButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openModelButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAllButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteModelButton = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.projectModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            dataTypeLabel = new System.Windows.Forms.Label();
            isForeignKeyLabel = new System.Windows.Forms.Label();
            primaryKeyLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.BusinessModelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTypeLabel
            // 
            dataTypeLabel.AutoSize = true;
            dataTypeLabel.Location = new System.Drawing.Point(24, 40);
            dataTypeLabel.Name = "dataTypeLabel";
            dataTypeLabel.Size = new System.Drawing.Size(60, 13);
            dataTypeLabel.TabIndex = 0;
            dataTypeLabel.Text = "Data Type:";
            // 
            // isForeignKeyLabel
            // 
            isForeignKeyLabel.AutoSize = true;
            isForeignKeyLabel.Location = new System.Drawing.Point(128, 69);
            isForeignKeyLabel.Name = "isForeignKeyLabel";
            isForeignKeyLabel.Size = new System.Drawing.Size(77, 13);
            isForeignKeyLabel.TabIndex = 2;
            isForeignKeyLabel.Text = "Is Foreign Key:";
            // 
            // primaryKeyLabel
            // 
            primaryKeyLabel.AutoSize = true;
            primaryKeyLabel.Location = new System.Drawing.Point(9, 69);
            primaryKeyLabel.Name = "primaryKeyLabel";
            primaryKeyLabel.Size = new System.Drawing.Size(76, 13);
            primaryKeyLabel.TabIndex = 4;
            primaryKeyLabel.Text = "Is Primary Key:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(47, 8);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(264, 69);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 13);
            label1.TabIndex = 9;
            label1.Text = "Is Nullable";
            // 
            // BusinessModelPanel
            // 
            this.BusinessModelPanel.Controls.Add(label1);
            this.BusinessModelPanel.Controls.Add(this.nullableCheckBox);
            this.BusinessModelPanel.Controls.Add(this.typeComboBox);
            this.BusinessModelPanel.Controls.Add(dataTypeLabel);
            this.BusinessModelPanel.Controls.Add(isForeignKeyLabel);
            this.BusinessModelPanel.Controls.Add(this.foreignKeyCheckBox);
            this.BusinessModelPanel.Controls.Add(primaryKeyLabel);
            this.BusinessModelPanel.Controls.Add(this.primaryKeyCheckBox);
            this.BusinessModelPanel.Controls.Add(nameLabel);
            this.BusinessModelPanel.Controls.Add(this.nameTextBox);
            this.BusinessModelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BusinessModelPanel.Location = new System.Drawing.Point(131, 69);
            this.BusinessModelPanel.Name = "BusinessModelPanel";
            this.BusinessModelPanel.Size = new System.Drawing.Size(390, 364);
            this.BusinessModelPanel.TabIndex = 0;
            // 
            // nullableCheckBox
            // 
            this.nullableCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.businessModelBindingSource, "IsForeignKey", true));
            this.nullableCheckBox.Location = new System.Drawing.Point(352, 64);
            this.nullableCheckBox.Name = "nullableCheckBox";
            this.nullableCheckBox.Size = new System.Drawing.Size(24, 24);
            this.nullableCheckBox.TabIndex = 10;
            this.nullableCheckBox.UseVisualStyleBackColor = true;
            // 
            // businessModelBindingSource
            // 
            this.businessModelBindingSource.DataSource = typeof(Coder.BusinessModel);
            // 
            // typeComboBox
            // 
            this.typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.modelsBindingSource, "Type", true));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(96, 32);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(272, 21);
            this.typeComboBox.TabIndex = 8;
            // 
            // modelsBindingSource
            // 
            this.modelsBindingSource.DataSource = typeof(Coder.BusinessModel);
            // 
            // foreignKeyCheckBox
            // 
            this.foreignKeyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.businessModelBindingSource, "IsForeignKey", true));
            this.foreignKeyCheckBox.Location = new System.Drawing.Point(216, 64);
            this.foreignKeyCheckBox.Name = "foreignKeyCheckBox";
            this.foreignKeyCheckBox.Size = new System.Drawing.Size(24, 24);
            this.foreignKeyCheckBox.TabIndex = 3;
            this.foreignKeyCheckBox.UseVisualStyleBackColor = true;
            // 
            // primaryKeyCheckBox
            // 
            this.primaryKeyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.businessModelBindingSource, "IsPrimaryKey", true));
            this.primaryKeyCheckBox.Location = new System.Drawing.Point(96, 64);
            this.primaryKeyCheckBox.Name = "primaryKeyCheckBox";
            this.primaryKeyCheckBox.Size = new System.Drawing.Size(24, 24);
            this.primaryKeyCheckBox.TabIndex = 5;
            this.primaryKeyCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessModelBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(96, 8);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(272, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // modelsListBox
            // 
            this.modelsListBox.DataSource = this.modelsBindingSource;
            this.modelsListBox.DisplayMember = "Name";
            this.modelsListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.modelsListBox.FormattingEnabled = true;
            this.modelsListBox.Location = new System.Drawing.Point(0, 49);
            this.modelsListBox.Name = "modelsListBox";
            this.modelsListBox.Size = new System.Drawing.Size(128, 384);
            this.modelsListBox.TabIndex = 8;
            this.modelsListBox.ValueMember = "DataType";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBusinessModelToolStripMenuItem,
            this.toolStripMenuItem1,
            this.openToolStripMenuItem,
            this.toolStripMenuItem3,
            this.saveAllToolStripMenuItem,
            this.toolStripMenuItem2,
            this.closeToolStripMenuItem,
            this.toolStripMenuItem4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newBusinessModelToolStripMenuItem
            // 
            this.newBusinessModelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.modelToolStripMenuItem});
            this.newBusinessModelToolStripMenuItem.Name = "newBusinessModelToolStripMenuItem";
            this.newBusinessModelToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newBusinessModelToolStripMenuItem.Text = "&New";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.projectToolStripMenuItem.Text = "Project";
            this.projectToolStripMenuItem.Click += new System.EventHandler(this.projectToolStripMenuItem_Click);
            // 
            // modelToolStripMenuItem
            // 
            this.modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            this.modelToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.modelToolStripMenuItem.Text = "Model";
            this.modelToolStripMenuItem.Click += new System.EventHandler(this.modelToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(100, 6);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveAllToolStripMenuItem.Text = "&Save";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Cl&ose";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newModelButton,
            this.toolStripSeparator1,
            this.openModelButton,
            this.toolStripSeparator3,
            this.saveAllButton,
            this.toolStripSeparator2,
            this.deleteModelButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(521, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newModelButton
            // 
            this.newModelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newModelButton.Image = ((System.Drawing.Image)(resources.GetObject("newModelButton.Image")));
            this.newModelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newModelButton.Name = "newModelButton";
            this.newModelButton.Size = new System.Drawing.Size(35, 22);
            this.newModelButton.Text = "New";
            this.newModelButton.Click += new System.EventHandler(this.newModelButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // openModelButton
            // 
            this.openModelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openModelButton.Image = ((System.Drawing.Image)(resources.GetObject("openModelButton.Image")));
            this.openModelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openModelButton.Name = "openModelButton";
            this.openModelButton.Size = new System.Drawing.Size(40, 22);
            this.openModelButton.Text = "Open";
            this.openModelButton.Click += new System.EventHandler(this.openModelButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // saveAllButton
            // 
            this.saveAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveAllButton.Image = ((System.Drawing.Image)(resources.GetObject("saveAllButton.Image")));
            this.saveAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAllButton.Name = "saveAllButton";
            this.saveAllButton.Size = new System.Drawing.Size(35, 22);
            this.saveAllButton.Text = "Save";
            this.saveAllButton.Click += new System.EventHandler(this.saveAllButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // deleteModelButton
            // 
            this.deleteModelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteModelButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteModelButton.Image")));
            this.deleteModelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteModelButton.Name = "deleteModelButton";
            this.deleteModelButton.Size = new System.Drawing.Size(44, 22);
            this.deleteModelButton.Text = "Delete";
            this.deleteModelButton.Click += new System.EventHandler(this.deleteModelButton_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(128, 49);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 384);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectModelBindingSource, "Name", true));
            this.projectNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectNameTextBox.Location = new System.Drawing.Point(131, 49);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(390, 20);
            this.projectNameTextBox.TabIndex = 9;
            // 
            // projectModelBindingSource
            // 
            this.projectModelBindingSource.DataSource = typeof(Coder.ProjectModel);
            // 
            // ProjectEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 433);
            this.Controls.Add(this.BusinessModelPanel);
            this.Controls.Add(this.projectNameTextBox);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.modelsListBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProjectEditor";
            this.Text = "Project Editor";
            this.BusinessModelPanel.ResumeLayout(false);
            this.BusinessModelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BusinessModelPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBusinessModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newModelButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton openModelButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton saveAllButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton deleteModelButton;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.CheckBox foreignKeyCheckBox;
        private System.Windows.Forms.CheckBox primaryKeyCheckBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ListBox modelsListBox;
        private System.Windows.Forms.BindingSource modelsBindingSource;
        private System.Windows.Forms.BindingSource businessModelBindingSource;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelToolStripMenuItem;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.BindingSource projectModelBindingSource;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.CheckBox nullableCheckBox;
    }
}

