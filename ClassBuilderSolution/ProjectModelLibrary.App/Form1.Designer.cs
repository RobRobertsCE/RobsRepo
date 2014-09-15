namespace ProjectModelLibrary.App
{
    partial class Form1
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label modelTypeLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label buildLabel;
            System.Windows.Forms.Label majorLabel;
            System.Windows.Forms.Label majorRevisionLabel;
            System.Windows.Forms.Label minorLabel;
            System.Windows.Forms.Label minorRevisionLabel;
            System.Windows.Forms.Label revisionLabel;
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.modelTypeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.buildTextBox = new System.Windows.Forms.TextBox();
            this.majorTextBox = new System.Windows.Forms.TextBox();
            this.majorRevisionTextBox = new System.Windows.Forms.TextBox();
            this.minorTextBox = new System.Windows.Forms.TextBox();
            this.minorRevisionTextBox = new System.Windows.Forms.TextBox();
            this.revisionTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            idLabel = new System.Windows.Forms.Label();
            modelTypeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            buildLabel = new System.Windows.Forms.Label();
            majorLabel = new System.Windows.Forms.Label();
            majorRevisionLabel = new System.Windows.Forms.Label();
            minorLabel = new System.Windows.Forms.Label();
            minorRevisionLabel = new System.Windows.Forms.Label();
            revisionLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(280, 33);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectModelBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(352, 30);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(208, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // modelTypeLabel
            // 
            modelTypeLabel.AutoSize = true;
            modelTypeLabel.Location = new System.Drawing.Point(280, 59);
            modelTypeLabel.Name = "modelTypeLabel";
            modelTypeLabel.Size = new System.Drawing.Size(66, 13);
            modelTypeLabel.TabIndex = 3;
            modelTypeLabel.Text = "Model Type:";
            // 
            // modelTypeTextBox
            // 
            this.modelTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectModelBindingSource, "ModelType", true));
            this.modelTypeTextBox.Location = new System.Drawing.Point(352, 56);
            this.modelTypeTextBox.Name = "modelTypeTextBox";
            this.modelTypeTextBox.Size = new System.Drawing.Size(208, 20);
            this.modelTypeTextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(280, 85);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectModelBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(352, 82);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(208, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(280, 111);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 7;
            stateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectModelBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(352, 108);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(208, 20);
            this.stateTextBox.TabIndex = 8;
            // 
            // buildLabel
            // 
            buildLabel.AutoSize = true;
            buildLabel.Location = new System.Drawing.Point(280, 169);
            buildLabel.Name = "buildLabel";
            buildLabel.Size = new System.Drawing.Size(33, 13);
            buildLabel.TabIndex = 9;
            buildLabel.Text = "Build:";
            // 
            // buildTextBox
            // 
            this.buildTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectModelBindingSource, "Version.Build", true));
            this.buildTextBox.Location = new System.Drawing.Point(368, 166);
            this.buildTextBox.Name = "buildTextBox";
            this.buildTextBox.Size = new System.Drawing.Size(100, 20);
            this.buildTextBox.TabIndex = 10;
            // 
            // majorLabel
            // 
            majorLabel.AutoSize = true;
            majorLabel.Location = new System.Drawing.Point(280, 195);
            majorLabel.Name = "majorLabel";
            majorLabel.Size = new System.Drawing.Size(36, 13);
            majorLabel.TabIndex = 11;
            majorLabel.Text = "Major:";
            // 
            // majorTextBox
            // 
            this.majorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectModelBindingSource, "Version.Major", true));
            this.majorTextBox.Location = new System.Drawing.Point(368, 192);
            this.majorTextBox.Name = "majorTextBox";
            this.majorTextBox.Size = new System.Drawing.Size(100, 20);
            this.majorTextBox.TabIndex = 12;
            // 
            // majorRevisionLabel
            // 
            majorRevisionLabel.AutoSize = true;
            majorRevisionLabel.Location = new System.Drawing.Point(280, 221);
            majorRevisionLabel.Name = "majorRevisionLabel";
            majorRevisionLabel.Size = new System.Drawing.Size(80, 13);
            majorRevisionLabel.TabIndex = 13;
            majorRevisionLabel.Text = "Major Revision:";
            // 
            // majorRevisionTextBox
            // 
            this.majorRevisionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectModelBindingSource, "Version.MajorRevision", true));
            this.majorRevisionTextBox.Location = new System.Drawing.Point(368, 218);
            this.majorRevisionTextBox.Name = "majorRevisionTextBox";
            this.majorRevisionTextBox.Size = new System.Drawing.Size(100, 20);
            this.majorRevisionTextBox.TabIndex = 14;
            // 
            // minorLabel
            // 
            minorLabel.AutoSize = true;
            minorLabel.Location = new System.Drawing.Point(280, 247);
            minorLabel.Name = "minorLabel";
            minorLabel.Size = new System.Drawing.Size(36, 13);
            minorLabel.TabIndex = 15;
            minorLabel.Text = "Minor:";
            // 
            // minorTextBox
            // 
            this.minorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectModelBindingSource, "Version.Minor", true));
            this.minorTextBox.Location = new System.Drawing.Point(368, 244);
            this.minorTextBox.Name = "minorTextBox";
            this.minorTextBox.Size = new System.Drawing.Size(100, 20);
            this.minorTextBox.TabIndex = 16;
            // 
            // minorRevisionLabel
            // 
            minorRevisionLabel.AutoSize = true;
            minorRevisionLabel.Location = new System.Drawing.Point(280, 273);
            minorRevisionLabel.Name = "minorRevisionLabel";
            minorRevisionLabel.Size = new System.Drawing.Size(80, 13);
            minorRevisionLabel.TabIndex = 17;
            minorRevisionLabel.Text = "Minor Revision:";
            // 
            // minorRevisionTextBox
            // 
            this.minorRevisionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectModelBindingSource, "Version.MinorRevision", true));
            this.minorRevisionTextBox.Location = new System.Drawing.Point(368, 270);
            this.minorRevisionTextBox.Name = "minorRevisionTextBox";
            this.minorRevisionTextBox.Size = new System.Drawing.Size(100, 20);
            this.minorRevisionTextBox.TabIndex = 18;
            // 
            // revisionLabel
            // 
            revisionLabel.AutoSize = true;
            revisionLabel.Location = new System.Drawing.Point(280, 299);
            revisionLabel.Name = "revisionLabel";
            revisionLabel.Size = new System.Drawing.Size(51, 13);
            revisionLabel.TabIndex = 19;
            revisionLabel.Text = "Revision:";
            // 
            // revisionTextBox
            // 
            this.revisionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectModelBindingSource, "Version.Revision", true));
            this.revisionTextBox.Location = new System.Drawing.Point(368, 296);
            this.revisionTextBox.Name = "revisionTextBox";
            this.revisionTextBox.Size = new System.Drawing.Size(100, 20);
            this.revisionTextBox.TabIndex = 20;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 322);
            this.listBox1.TabIndex = 22;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // projectModelBindingSource
            // 
            this.projectModelBindingSource.DataSource = typeof(ProjectModelLibrary.Models.ProjectModel);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 346);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(buildLabel);
            this.Controls.Add(this.buildTextBox);
            this.Controls.Add(majorLabel);
            this.Controls.Add(this.majorTextBox);
            this.Controls.Add(majorRevisionLabel);
            this.Controls.Add(this.majorRevisionTextBox);
            this.Controls.Add(minorLabel);
            this.Controls.Add(this.minorTextBox);
            this.Controls.Add(minorRevisionLabel);
            this.Controls.Add(this.minorRevisionTextBox);
            this.Controls.Add(revisionLabel);
            this.Controls.Add(this.revisionTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(modelTypeLabel);
            this.Controls.Add(this.modelTypeTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource projectModelBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox modelTypeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox buildTextBox;
        private System.Windows.Forms.TextBox majorTextBox;
        private System.Windows.Forms.TextBox majorRevisionTextBox;
        private System.Windows.Forms.TextBox minorTextBox;
        private System.Windows.Forms.TextBox minorRevisionTextBox;
        private System.Windows.Forms.TextBox revisionTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

    }
}

