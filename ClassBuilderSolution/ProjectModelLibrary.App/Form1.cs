using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectModelLibrary.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadProjects();
        }

        void LoadProjects()
        {
            ProjectManager m = new ProjectManager();
            listBox1.ValueMember = "Id";
            listBox1.DisplayMember = "Name";
            listBox1.DataSource = m.GetProjects();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            projectModelBindingSource.DataSource = listBox1.SelectedItem;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IProjectModel newProject = new Models.ProjectModel( "");
            projectModelBindingSource.DataSource = newProject;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IProjectModel newProject = (IProjectModel)projectModelBindingSource.DataSource;
            ProjectManager m = new ProjectManager();
            m.SaveProject(newProject);
            LoadProjects();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IProjectModel project = (IProjectModel)projectModelBindingSource.DataSource;
            ProjectManager m = new ProjectManager();
            m.DeleteProject(project.Id);
            LoadProjects();
        }
    }
}
