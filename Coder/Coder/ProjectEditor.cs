using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coder
{
    public partial class ProjectEditor : Form
    {
        #region fields
        public ProjectModel Project { get; set; }
        #endregion

        #region ctor / init
        public ProjectEditor()
        {
            InitializeComponent();

            InitializeTypeList();

            InitializeBindings();

        }
        void InitializeTypeList()
        {
            List<Type> types = new List<Type>();
            types.Add(typeof(System.String));
            types.Add(typeof(System.Int16));
            types.Add(typeof(System.Int32));
            types.Add(typeof(System.Int64));
            types.Add(typeof(System.Boolean));
            types.Add(typeof(System.Guid));
            types.Add(typeof(System.Collections.Generic.IList<Object>));
            types.Add(typeof(System.Collections.Generic.ICollection<Object>));

            typeComboBox.DataSource = types;
        }
        #endregion

        #region data binding
        void InitializeBindings()
        {        
            modelsBindingSource.CurrentChanged += modelsBindingSource_CurrentChanged;
        }
        void modelsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            businessModelBindingSource.DataSource = modelsBindingSource.Current;
        }  
        #endregion

        #region new model
        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateBusinessModel();
        }
        private void newModelButton_Click(object sender, EventArgs e)
        {
            CreateBusinessModel();
        }
        void CreateBusinessModel()
        {
            modelsBindingSource.Add(new BusinessModel());
        }
        #endregion

        #region delete model
        private void deleteModelButton_Click(object sender, EventArgs e)
        {
            DeleteBusinessModel();
        }
        void DeleteBusinessModel()
        {
            modelsBindingSource.RemoveCurrent();
        }
        #endregion

        #region save models
        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveModels();
        }
        private void saveAllButton_Click(object sender, EventArgs e)
        {
            SaveModels();
        }
        void SaveModels()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSON (*.json.txt)|*.json.txt|All (*.*)|*.*";
            dialog.FileOk += saveFileDialog_FileOk;
            dialog.FileName = Project.Name;
            dialog.ShowDialog(this);
        }
        void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Project.Save(((SaveFileDialog)sender).FileName);
        }
        #endregion

        #region open models
        private void openModelButton_Click(object sender, EventArgs e)
        {
            LoadModels();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadModels();
        }
        void LoadModels()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON (*.json.txt)|*.json.txt|All (*.*)|*.*";
            dialog.FilterIndex = 0;
            dialog.FileOk += openFiledialog_FileOk;
            dialog.ShowDialog(this);
        }
        void openFiledialog_FileOk(object sender, CancelEventArgs e)
        {
            NewProject();
            Project = ProjectModel.Load(((OpenFileDialog)sender).FileName);
            projectModelBindingSource.DataSource = Project;
            modelsBindingSource.DataSource = Project.Models; 
        }
        #endregion

        #region  close project
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseProject();
        }
        void CloseProject()
        {
            Project = null;
        }
        #endregion

        #region new project
        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProject();
        }
        void NewProject()
        {
            Project = new ProjectModel();
            modelsBindingSource.DataSource = Project.Models;
            projectNameTextBox.Text = Project.Name;
        }
        #endregion

        #region exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
