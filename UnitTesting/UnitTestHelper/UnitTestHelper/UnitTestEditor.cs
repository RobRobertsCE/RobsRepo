using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UnitTestHelperLibrary;
using UnitTestHelperLibrary.CodeGenerators;

namespace UnitTestHelper
{
    public partial class UnitTestEditor : Form
    {
        #region unit test target assembly
        UnitTestTargetAssembly _unitTestTarget = null;

        public UnitTestTargetAssembly UnitTestTarget
        {
            get
            {
                return _unitTestTarget;
            }
            set
            {
                _unitTestTarget = value;

                UnitTestTargetChanged();
            }
        }

        void UnitTestTargetChanged()
        {
            DisplayUnitTestTargetModels();
        }
        #endregion

        #region ctor
        public UnitTestEditor()
        {
            InitializeComponent();
        } 
        #endregion

        #region app close
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseRequested();
        }

        void CloseRequested()
        {
            // unsaved work?
            this.Close();
        }
        #endregion

        #region load unit test target assembly
        private void openAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayOpenFileDialog();
        }

        void DisplayOpenFileDialog()
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (DialogResult.OK == dialog.ShowDialog())
                {
                    LoadAssembly(dialog.FileName);
                }
            }
        }

        void LoadAssembly(string assemblyPath)
        {
            UnitTestTarget = new UnitTestTargetAssembly(assemblyPath);
        }
        #endregion

        #region display unit test target assembly models
        void DisplayUnitTestTargetModels()
        {
            modelsListBox.DataSource = null;

            modelsListBox.DataSource = _unitTestTarget.AssemblyModels;
        }
        #endregion

        #region generate tests and code 
        private void modelsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            generateCodeButton.Enabled = (null != modelsListBox.SelectedItem);
        }

        private void generateCodeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (null == modelsListBox.SelectedItem) return;

                codeTextBox.Text = GenerateCode(modelsListBox.SelectedItem as AssemblyModel);

                testTextBox.Text = GenerateTests(modelsListBox.SelectedItem as AssemblyModel);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }

        string GenerateCode(AssemblyModel model)
        {
            using (ICodeGenerator generator = new ValidationCodeGenerator(model))
            {
                return generator.GenerateCode();
            }
        }

        string GenerateTests(AssemblyModel model)
        {
            using (ICodeGenerator generator = new UnitTestCodeGenerator(model))
            {
                return generator.GenerateCode();
            }
        }

        #endregion

    }
}
