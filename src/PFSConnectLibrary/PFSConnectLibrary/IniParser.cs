using System;
using System.Reflection;

namespace PFSConnectLibrary
{
    public sealed class IniParser : IDisposable
    {
        public PFSConnectModel IniModel { get; private set; }

        string iniFileContent;

        const int KEY = 0;
        const int VALUE = 1;

        public IniParser(string fileContent)
        {
            this.iniFileContent = fileContent;

            IniModel = ParseIniContent();
        }

        PFSConnectModel ParseIniContent()
        {
            PFSConnectModel model = new PFSConnectModel();

            bool isDefaultDatabase = true;
            string line = string.Empty;
            string dbModelDataSource = string.Empty;
            string dbModelCatalog = string.Empty;
            string dbModelUserId = string.Empty;
            string dbModelPassword = string.Empty;

            using (System.IO.StringReader contentReader = new System.IO.StringReader(iniFileContent))
            {
                while ((line = contentReader.ReadLine()) != null)
                {
                    if (!String.IsNullOrEmpty(line))
                    {                       

                        if (line.ToUpper().Contains("DATASOURCE") | (line.ToUpper().Contains("CATALOG")) | line.ToUpper().Contains("USERID") | (line.ToUpper().Contains("PASSWORD")))
                        {
                            isDefaultDatabase = (
                                !(
                                    (line.ToUpper().StartsWith("#DATASOURCE")) | 
                                    (line.ToUpper().StartsWith("#CATALOG")) | 
                                    (line.ToUpper().StartsWith("#USERID")) | 
                                    (line.ToUpper().StartsWith("#PASSWORD"))
                                ));                            

                            if (line.StartsWith("#"))
                            {
                                line = line.TrimStart('#');
                            }

                            string[] keyValue = line.Split('=');

                            if (keyValue[KEY].ToUpper() == "DATASOURCE")
                            {
                                dbModelDataSource = keyValue[VALUE];
                            }
                            else if (keyValue[KEY].ToUpper() == "CATALOG")
                            {
                                dbModelCatalog = keyValue[VALUE];
                            }
                            else if (keyValue[KEY].ToUpper() == "USERID")
                            {
                                dbModelUserId = keyValue[VALUE];
                            }
                            else if (keyValue[KEY].ToUpper() == "PASSWORD")
                            {
                                dbModelPassword = keyValue[VALUE];
                            }

                            if ((!String.IsNullOrEmpty(dbModelDataSource)) && (!String.IsNullOrEmpty(dbModelCatalog)) && (!String.IsNullOrEmpty(dbModelUserId)) && (!String.IsNullOrEmpty(dbModelPassword)))
                            {
                                model.Databases.Add(new DatabaseModel(dbModelDataSource, dbModelCatalog, dbModelUserId, dbModelPassword, isDefaultDatabase));
                                dbModelDataSource = string.Empty;
                                dbModelCatalog = string.Empty;
                                isDefaultDatabase = true;
                            }
                        }
                        else
                        {
                            if (!line.StartsWith("#") && !line.StartsWith("[") && !String.IsNullOrEmpty(line))
                            {
                                string[] keyValue = line.Split('=');

                                PropertyInfo propertyInfo = model.GetType().GetProperty(keyValue[KEY].ToUpper());

                                propertyInfo.SetValue(model, Convert.ChangeType(keyValue[VALUE], propertyInfo.PropertyType), null);

                            }
                        }
                    }
                }
            }

            return model;
        }

        public void Dispose()
        {

        }
    }
}
