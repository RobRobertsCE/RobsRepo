
namespace PFSConnectLibrary
{
    public class DatabaseModel : BusinessObjectBase
    {
        public string DATASOURCE { get; set; }

        public string CATALOG { get; set; }

        public string PASSWORD { get; set; }

        public string USERID { get; set; }

        public bool IsDefault { get; set; }

        public string DisplayName
        {
            get
            {
                return this.ToString();
            }
        }

        public DatabaseModel(string dataSource, string catalog, string userId, string password)
        {
            DATASOURCE = dataSource;
            CATALOG = catalog;
            USERID = userId;
            PASSWORD = password;
        }

        public DatabaseModel(string dataSource, string catalog, string userId, string password, bool isDefault)
        {
            DATASOURCE = dataSource;
            CATALOG = catalog;
            USERID = userId;
            PASSWORD = password;
            IsDefault = isDefault;
        }

        public DatabaseModel()
        {

        }

        public override string ToString()
        {
            return string.Format("{0}.{1}", DATASOURCE, CATALOG);
        }

    }
}
