using System.Windows.Forms;
using PFSConnectLibrary;

namespace PfsConnectTestApp
{
    public partial class DatabaseEditor : Form
    {
        public DatabaseModel DatabaseModel { get; set; }

        public DatabaseEditor()
            : this(new DatabaseModel())
        {           
        }

        public DatabaseEditor(DatabaseModel model) 
        {
            InitializeComponent();

            DatabaseModel = model;

            databaseModelBindingSource.DataSource = DatabaseModel;
        }

    }
}
