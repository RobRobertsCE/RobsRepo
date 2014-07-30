using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PFSConnectLibrary;

namespace PfsConnectTestApp
{
    public partial class IniEditor : Form
    {
        PFSConnectModel model = null;
        bool loading = true;

        public IniEditor()
        {
            InitializeComponent();

            iniFileNameTextBox.Text = Common.DEFAULT_FILE_PATH;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadIniFile();
        }

        private void readINI_Click(object sender, EventArgs e)
        {
            ReadIniFile();
        }

        private void ReadIniFile()
        {
            loading = true;

            string content = System.IO.File.ReadAllText(iniFileNameTextBox.Text);

            model = PFSConnectModel.GetPFSConnectModel(content);

            DisplayDatabases(model);

            pFSConnectModelBindingSource.DataSource = model;

            databaseList.SelectedItem = model.DefaultDatabase;

            loading = false;
        }

        private void DisplayDatabases(PFSConnectModel model)
        {
            try
            {
                this.databaseList.DisplayMember = "DisplayName";

                this.databaseList.DataSource = model.Databases.GetList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void databaseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (databaseList.SelectedItem == null) return;

            if (loading) return;

            model.Databases.SetDefaultDatabaseModel((DatabaseModel)databaseList.SelectedItem);

            WriteIni();
        }

        private void writeINI_Click(object sender, EventArgs e)
        {
            WriteIni(iniFileNameTextBox.Text);
        }

        void WriteIni()
        {
            WriteIni(iniFileNameTextBox.Text);
        }

        void WriteIni(string filePath)
        {
            using (IniWriter writer = new IniWriter(model))
            {
                writer.WriteIniFile(filePath);
            }
        }

        private void newDatabaseButton_Click(object sender, EventArgs e)
        {
            DisplayDatabaseEditor();
        }

        private void DisplayDatabaseEditor()
        {
            using (DatabaseEditor editor = new DatabaseEditor())
            {

                DialogResult result = editor.ShowDialog(this);

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    DatabaseModel newDbModel = editor.DatabaseModel;

                    model.Databases.Add(newDbModel);

                    if (true == newDbModel.IsDefault)
                        model.Databases.SetDefaultDatabaseModel(newDbModel);

                }
            }
        }

        private void deleteDatabaseButton_Click(object sender, EventArgs e)
        {
            DeleteSelectedDatabase();
        }

        private void DeleteSelectedDatabase()
        {
            if (databaseList.SelectedItem == null) return;

            model.Databases.Remove((DatabaseModel)databaseList.SelectedItem);

            if (model.Databases.Count > 0) this.databaseList.SelectedIndex = 0;

            WriteIni();
        }
    }
}
