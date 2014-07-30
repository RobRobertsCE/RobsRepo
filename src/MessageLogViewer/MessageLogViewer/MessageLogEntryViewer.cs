using MessageLog.Business;

using PFSConnectLibrary;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageLogViewer
{
    public partial class MessageLogEntryViewer : Form
    {
        #region fields
        MessageLogEntries entries = null;
        
        PFSConnectModel model = null;

        bool loading = false;
        
        #endregion

        #region ctor / form load / init
        public MessageLogEntryViewer()
        {
            InitializeComponent();

            this.Load += Form1_Load;

        }

        void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                GetPFSConnectModel();
               
                PopulateDatabaseSelectionControl(model);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }

        void GetPFSConnectModel()
        {
            string content = File.ReadAllText(PFSConnectLibrary.Common.DEFAULT_FILE_PATH);

            model = PFSConnectModel.GetPFSConnectModel(content);

        }
        
        void PopulateDatabaseSelectionControl(PFSConnectModel model)
        {
            loading = true;

            this.databaseList.DisplayMember = "DisplayName";

            this.databaseList.DataSource = model.Databases.GetList();

            loading = false;

            this.databaseList.SelectedItem = model.Databases.DefaultDatabase;
        }

        #endregion

        #region database selection
        void databaseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;

            if (this.databaseList.SelectedItem == null) return;

            UpdateSelectedDatabase((DatabaseModel)databaseList.SelectedItem);
        }

        void UpdateSelectedDatabase(DatabaseModel dbModel)
        {
            SetDatabaseLabelsText(dbModel);
            SetFilterLabelText("~");

            string cnString = ConnectionStringFactory.GetDbContextConnectionString(dbModel, typeof(MessageLog.Data.MessageLogContext).Assembly.FullName, "MessageLogContext");

            MessageLogEntries.EfConnectionString = cnString;

            InitializeSelectionControls(cnString);

            messageListViewer1.messageLogEntriesBindingSource.DataSource = null;
        }

        void InitializeSelectionControls(string cnString)
        {
            try
            {
                loading = true;

                employeeComboBox.Items.Clear();
                employeeComboBox.Items.Add("All");
                foreach (int emoloyeeNo in MessageEmployees.GetEmployeeNumberList(cnString))
                {
                    employeeComboBox.Items.Add(emoloyeeNo);
                }
                employeeComboBox.SelectedIndex = 0;


                stationComboBox.Items.Clear();
                stationComboBox.Items.Add("All");
                foreach (int stationNo in MessageStations.GetStationList(cnString))
                {
                    stationComboBox.Items.Add(stationNo);
                }
                stationComboBox.SelectedIndex = 0;


                programComboBox.Items.Clear();
                programComboBox.Items.Add("All");
                foreach (string programName in MessagePrograms.GetProgramList(cnString))
                {
                    programComboBox.Items.Add(programName);
                }
                programComboBox.SelectedIndex = 0;

                EnableDateRangeControls();

                startDateTimePicker.Value = DateTime.Today.Subtract(TimeSpan.FromDays(1));

                messageListViewer1.messageLogEntriesBindingSource.CurrentChanged += messageLogEntriesBindingSource_CurrentChanged;

                loading = false;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        
        #endregion

        #region status bar updates
        void SetFilterLabelText(string filter)
        {
            filterStatusLabel.Text = String.Format("Filter: {0}", filter);
        }

        void SetDatabaseLabelsText(DatabaseModel dbModel)
        {
            databaseNameStatusLabel.Text = String.Format("Database: {0}", dbModel.DisplayName);
            useridStatusLabel.Text = String.Format("UserId: {0}", dbModel.USERID);
            passwordStatusLabel.Text = String.Format("Password: {0}", dbModel.PASSWORD);
        }
        
        void UpdateRecordCountLabel()
        {
            recordCountStatusLabel.Text = String.Format("Displaying {0} record(s).", entries.Count);
        }

        #endregion

        #region data bindings
        void messageLogEntriesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.messageViewer1.messageLogEntryBindingSource.DataSource = messageListViewer1.messageLogEntriesBindingSource.Current;
        }

        void ResetDataBindings()
        {
            messageListViewer1.messageLogEntriesBindingSource.DataSource = entries;
            messageViewer1.messageLogEntryBindingSource.DataSource = messageListViewer1.messageLogEntriesBindingSource.Current;

        }

        #endregion

        #region datetime controls
        private void dateRangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dateRangeCheckBox.Checked)
                EnableDateRangeControls();
            else
                DisableDateRangeControls();

            SearchCriteriaChanged(sender, e);
        }
        private void EnableDateRangeControls()
        {
            startDateTimePicker.Enabled = true;
            endDateTimePicker.Enabled = true;
        }
        private void DisableDateRangeControls()
        {
            startDateTimePicker.Enabled = false;
            endDateTimePicker.Enabled = false;
        }
        private bool UseDateRangeFilter
        {
            get
            {
                return dateRangeCheckBox.Checked;
            }
        }

        #endregion

        #region perform search
        private void searchButton_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void SearchCriteriaChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        void PerformSearch()
        {
            if (loading) return;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                this.SuspendLayout();

                LoadEntries();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                this.ResumeLayout();

                this.Cursor = Cursors.Default;
            }
        }

        #endregion

        #region criteria control changed event handlers
        private void countComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchCriteriaChanged(sender, e);
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SearchCriteriaChanged(sender, e);
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SearchCriteriaChanged(sender, e);
        }

        private void messageSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchCriteriaChanged(sender, e);
        }

        private void stackTraceSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchCriteriaChanged(sender, e);
        }

        private void employeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchCriteriaChanged(sender, e);
        }

        private void stationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchCriteriaChanged(sender, e);
        }

        private void programComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchCriteriaChanged(sender, e);
        }

        private void errorOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SearchCriteriaChanged(sender, e);
        }

        #endregion

        #region load entities
        void LoadEntries()
        {
            StringBuilder filter = new StringBuilder();

            int take = countComboBox.SelectedIndex > 0 ? Convert.ToInt32(countComboBox.Text) : 0;

            var e = MessageLogEntries.Entries().AsQueryable();

            if (stationComboBox.SelectedIndex > 0)
            {
                int stationCriteria = Convert.ToInt32(stationComboBox.Text);
                filter.AppendFormat("StationNo={0}, ", stationCriteria);
                e = e.Where(m => m.Station == stationCriteria);
            }

            if (programComboBox.SelectedIndex > 0)
            {
                string programCriteria = programComboBox.Text;
                filter.AppendFormat("ProgramName={0}, ", programCriteria);
                e = e.Where(m => m.ProgramName == programCriteria);
            }

            if (employeeComboBox.SelectedIndex > 0)
            {
                int employeeCriteria = Convert.ToInt32(employeeComboBox.Text);
                filter.AppendFormat("Employee={0}, ", employeeCriteria);
                e = e.Where(m => m.EmployeeNumber == employeeCriteria);
            }

            if (UseDateRangeFilter)
            {
                DateTime startDateRange = startDateTimePicker.Value;
                DateTime endDateRange = endDateTimePicker.Value;
                filter.AppendFormat("Timestamp between {0} and {1}, ", startDateRange, endDateRange);
                e = e.Where(m => m.Timestamp >= startDateRange & m.Timestamp <= endDateRange);
            }

            if (!string.IsNullOrEmpty(messageSearchTextBox.Text))
            {
                string messageSearchFilter = messageSearchTextBox.Text;
                filter.AppendFormat("Message contains '{0}', ", messageSearchFilter);
                e = e.Where(m => m.Message.Contains(messageSearchFilter));
            }

            if (!string.IsNullOrEmpty(stackTraceSearchTextBox.Text))
            {
                string stackSearchFilter = stackTraceSearchTextBox.Text;
                filter.AppendFormat("Stack Trace contains '{0}', ", stackSearchFilter);
                e = e.Where(m => m.StackTrace.Contains(stackSearchFilter));
            }

            if (errorOnlyCheckBox.Checked)
            {
                filter.Append("Only Errors, ");
                e = e.Where(m => m.ErrorMessage == true);
            }

            if (take > 0)
            {
                e = e.Take(take);
            }

            entries = new MessageLogEntries(e.AsQueryable());

            ResetDataBindings();
            
            SetFilterLabelText(filter.ToString());

            UpdateRecordCountLabel();
        }

        #endregion

    }
}
