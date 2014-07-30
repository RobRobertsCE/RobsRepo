using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace PFSConnectLibrary
{
    public class PFSConnectModel : BusinessObjectBase, INotifyPropertyChanged 
    {
        public string TRAINING { get; set; }

        public bool PERSISTSECURITY { get; set; }

        public string WORKSTATION { get; set; }

        public int SQLDEPENDENCY { get; set; }

        public string PACKETSIZE { get; set; }

        public int INTEGRATEDSECURITY { get; set; }

        public int PASSWORDENCRYPTION { get; set; }

        public int STATIONNO { get; set; }

        public string REPORTPATH { get; set; }

        public DatabaseModel DefaultDatabase
        {
            get
            {
                return Databases.DefaultDatabase;
            }
        }

        public DatabaseModelLibrary Databases { get; set; }

        internal PFSConnectModel()
        {
            Databases = new DatabaseModelLibrary();

            Databases.PropertyChanged += Databases_PropertyChanged;
        }

        void Databases_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged("DefaultDatabase");
        }

        public static PFSConnectModel GetPFSConnectModel()
        {
            using (System.IO.StreamReader iniFile =   new System.IO.StreamReader(Common.DEFAULT_FILE_PATH))
            {
                string fileContent = iniFile.ReadToEnd();
                using (IniParser parser = new IniParser(fileContent))
                {
                    return parser.IniModel;
                }
            }
        }

        public static PFSConnectModel GetPFSConnectModel(string fileContent)
        {
            using (IniParser parser = new IniParser(fileContent))
            {
                return parser.IniModel;
            }
        }

        //public event PropertyChangedEventHandler PropertyChanged;
    }
}
