namespace PfsConnectTestApp
{
    partial class DatabaseEditor
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
            System.Windows.Forms.Label cATALOGLabel;
            System.Windows.Forms.Label dATASOURCELabel;
            System.Windows.Forms.Label isDefaultLabel;
            System.Windows.Forms.Label pASSWORDLabel;
            System.Windows.Forms.Label uSERIDLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.cATALOGTextBox = new System.Windows.Forms.TextBox();
            this.databaseModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATASOURCETextBox = new System.Windows.Forms.TextBox();
            this.isDefaultCheckBox = new System.Windows.Forms.CheckBox();
            this.pASSWORDTextBox = new System.Windows.Forms.TextBox();
            this.uSERIDTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            cATALOGLabel = new System.Windows.Forms.Label();
            dATASOURCELabel = new System.Windows.Forms.Label();
            isDefaultLabel = new System.Windows.Forms.Label();
            pASSWORDLabel = new System.Windows.Forms.Label();
            uSERIDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cATALOGLabel
            // 
            cATALOGLabel.AutoSize = true;
            cATALOGLabel.Location = new System.Drawing.Point(5, 50);
            cATALOGLabel.Name = "cATALOGLabel";
            cATALOGLabel.Size = new System.Drawing.Size(72, 17);
            cATALOGLabel.TabIndex = 1;
            cATALOGLabel.Text = "CATALOG:";
            // 
            // dATASOURCELabel
            // 
            dATASOURCELabel.AutoSize = true;
            dATASOURCELabel.Location = new System.Drawing.Point(5, 18);
            dATASOURCELabel.Name = "dATASOURCELabel";
            dATASOURCELabel.Size = new System.Drawing.Size(100, 17);
            dATASOURCELabel.TabIndex = 3;
            dATASOURCELabel.Text = "DATASOURCE:";
            // 
            // isDefaultLabel
            // 
            isDefaultLabel.AutoSize = true;
            isDefaultLabel.Location = new System.Drawing.Point(5, 85);
            isDefaultLabel.Name = "isDefaultLabel";
            isDefaultLabel.Size = new System.Drawing.Size(97, 17);
            isDefaultLabel.TabIndex = 5;
            isDefaultLabel.Text = "Set as Default:";
            // 
            // pASSWORDLabel
            // 
            pASSWORDLabel.Location = new System.Drawing.Point(0, 0);
            pASSWORDLabel.Name = "pASSWORDLabel";
            pASSWORDLabel.Size = new System.Drawing.Size(100, 23);
            pASSWORDLabel.TabIndex = 13;
            // 
            // uSERIDLabel
            // 
            uSERIDLabel.Location = new System.Drawing.Point(0, 0);
            uSERIDLabel.Name = "uSERIDLabel";
            uSERIDLabel.Size = new System.Drawing.Size(100, 23);
            uSERIDLabel.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(361, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 17);
            label1.TabIndex = 15;
            label1.Text = "USERID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(334, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 17);
            label2.TabIndex = 16;
            label2.Text = "PASSWORD:";
            // 
            // cATALOGTextBox
            // 
            this.cATALOGTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.cATALOGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.databaseModelBindingSource, "CATALOG", true));
            this.cATALOGTextBox.Location = new System.Drawing.Point(110, 47);
            this.cATALOGTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cATALOGTextBox.Name = "cATALOGTextBox";
            this.cATALOGTextBox.Size = new System.Drawing.Size(207, 24);
            this.cATALOGTextBox.TabIndex = 1;
            // 
            // databaseModelBindingSource
            // 
            this.databaseModelBindingSource.DataSource = typeof(PFSConnectLibrary.DatabaseModel);
            // 
            // dATASOURCETextBox
            // 
            this.dATASOURCETextBox.BackColor = System.Drawing.SystemColors.Info;
            this.dATASOURCETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.databaseModelBindingSource, "DATASOURCE", true));
            this.dATASOURCETextBox.Location = new System.Drawing.Point(110, 15);
            this.dATASOURCETextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dATASOURCETextBox.Name = "dATASOURCETextBox";
            this.dATASOURCETextBox.Size = new System.Drawing.Size(207, 24);
            this.dATASOURCETextBox.TabIndex = 0;
            // 
            // isDefaultCheckBox
            // 
            this.isDefaultCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.databaseModelBindingSource, "IsDefault", true));
            this.isDefaultCheckBox.Location = new System.Drawing.Point(110, 79);
            this.isDefaultCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.isDefaultCheckBox.Name = "isDefaultCheckBox";
            this.isDefaultCheckBox.Size = new System.Drawing.Size(121, 30);
            this.isDefaultCheckBox.TabIndex = 4;
            this.isDefaultCheckBox.UseVisualStyleBackColor = true;
            // 
            // pASSWORDTextBox
            // 
            this.pASSWORDTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.pASSWORDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.databaseModelBindingSource, "PASSWORD", true));
            this.pASSWORDTextBox.Location = new System.Drawing.Point(429, 47);
            this.pASSWORDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pASSWORDTextBox.Name = "pASSWORDTextBox";
            this.pASSWORDTextBox.Size = new System.Drawing.Size(88, 24);
            this.pASSWORDTextBox.TabIndex = 3;
            this.pASSWORDTextBox.Text = "sql";
            // 
            // uSERIDTextBox
            // 
            this.uSERIDTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.uSERIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.databaseModelBindingSource, "USERID", true));
            this.uSERIDTextBox.Location = new System.Drawing.Point(430, 15);
            this.uSERIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uSERIDTextBox.Name = "uSERIDTextBox";
            this.uSERIDTextBox.Size = new System.Drawing.Size(88, 24);
            this.uSERIDTextBox.TabIndex = 2;
            this.uSERIDTextBox.Text = "sa";
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(430, 110);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(87, 28);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(335, 110);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 28);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // DatabaseEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(529, 151);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(cATALOGLabel);
            this.Controls.Add(this.cATALOGTextBox);
            this.Controls.Add(dATASOURCELabel);
            this.Controls.Add(this.dATASOURCETextBox);
            this.Controls.Add(isDefaultLabel);
            this.Controls.Add(this.isDefaultCheckBox);
            this.Controls.Add(pASSWORDLabel);
            this.Controls.Add(this.pASSWORDTextBox);
            this.Controls.Add(uSERIDLabel);
            this.Controls.Add(this.uSERIDTextBox);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DatabaseEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Database";
            ((System.ComponentModel.ISupportInitialize)(this.databaseModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource databaseModelBindingSource;
        private System.Windows.Forms.TextBox cATALOGTextBox;
        private System.Windows.Forms.TextBox dATASOURCETextBox;
        private System.Windows.Forms.CheckBox isDefaultCheckBox;
        private System.Windows.Forms.TextBox pASSWORDTextBox;
        private System.Windows.Forms.TextBox uSERIDTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}