using System.Data.EntityClient;
using System.Data.SqlClient;

namespace PFSConnectLibrary
{
    public static class ConnectionStringFactory
    {
        public static string GetSqlConnectionString(DatabaseModel model)
        {
            SqlConnectionStringBuilder cnsb = new SqlConnectionStringBuilder();

            cnsb.DataSource = model.DATASOURCE;
            cnsb.InitialCatalog = model.CATALOG;
            cnsb.UserID = model.USERID;
            cnsb.Password = model.PASSWORD;

            return cnsb.ConnectionString;
        }

        public static string GetDbContextConnectionString(DatabaseModel model, string assemblyFullName, string dbContextName)
        {
            EntityConnectionStringBuilder ecb = new EntityConnectionStringBuilder();
            ecb.Metadata = string.Format("res://{0}/{1}.csdl|res://{0}/{1}.ssdl|res://{0}/{1}.msl",
      assemblyFullName, dbContextName);
            //ecb.Metadata = string.Format("res://*/{0}.csdl|res://*/{0}.ssdl|res://*/{0}.msl", dbContextName);
            ecb.Provider = "System.Data.SqlClient";
            ecb.ProviderConnectionString = ConnectionStringFactory.GetSqlConnectionString(model);

            return ecb.ConnectionString;
        }
    }
}
