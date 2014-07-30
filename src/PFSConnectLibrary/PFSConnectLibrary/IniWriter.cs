using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PFSConnectLibrary
{
    public sealed class IniWriter : IDisposable
    {
        public PFSConnectModel IniModel { get; private set; }

        public IniWriter(PFSConnectModel model)
        {
            IniModel = model;
        }

        public void WriteIniFile()
        {
            WriteIniFile(Common.DEFAULT_FILE_PATH);
        }

        public void WriteIniFile(string path)
        {
            string content = buildIniContent();

            File.WriteAllText(path, content);
        }

        private string buildIniContent()
        {
            StringBuilder sb = new StringBuilder();
            const string commentMarker = "#";
            const string noCommentMarker = "";
            string commentCharacter;

            sb.AppendLine("[SQL2000]");
            foreach (DatabaseModel dbModel in IniModel.Databases.GetList())
            {
                if (dbModel.IsDefault)
                    commentCharacter = noCommentMarker;
                else
                    commentCharacter = commentMarker;

                sb.AppendLine("#--------------------");
                sb.AppendLine(String.Format("{0}DATASOURCE={1}", commentCharacter, dbModel.DATASOURCE));
                sb.AppendLine(String.Format("{0}CATALOG={1}", commentCharacter, dbModel.CATALOG));
                sb.AppendLine(String.Format("{0}USERID={1}", commentCharacter, dbModel.USERID));
                sb.AppendLine(String.Format("{0}PASSWORD={1}", commentCharacter, dbModel.PASSWORD));
            }
            sb.AppendLine("#--------------------");
            sb.AppendLine();

            sb.AppendLine(String.Format("TRAINING={0}", IniModel.TRAINING));
            sb.AppendLine(String.Format("PERSISTSECURITY={0}", IniModel.PERSISTSECURITY));
            sb.AppendLine(String.Format("WORKSTATION={0}", IniModel.WORKSTATION));
            sb.AppendLine(String.Format("SQLDEPENDENCY={0}", IniModel.SQLDEPENDENCY));
            sb.AppendLine(String.Format("PACKETSIZE={0}", IniModel.PACKETSIZE));
            sb.AppendLine(String.Format("INTEGRATEDSECURITY={0}", IniModel.INTEGRATEDSECURITY));
            sb.AppendLine(String.Format("PASSWORDENCRYPTION={0}", IniModel.PASSWORDENCRYPTION));
            sb.AppendLine();

            sb.AppendLine("[INFO]");
            sb.AppendLine(String.Format("STATIONNO={0}", IniModel.STATIONNO));
            sb.AppendLine(String.Format("REPORTPATH={0}", IniModel.REPORTPATH));

            return sb.ToString();
        }
        /*
         * [SQL2000]
PASSWORD=sql
USERID=sa
#--------------------
#DATASOURCE=CESERVER
#CATALOG=TEST141
#--------------------
DATASOURCE=.\SQLEXPRESS
CATALOG=TEST144
#--------------------
#DATASOURCE=CESERVER
#DATASOURCE=10.68.2.6
#CATALOG=TEST143
#--------------------
#DataSource=centeredgetest1
#Catalog=centeredge_documentation
#--------------------
#DATASOURCE=cetestan1
#CATALOG=oldppointe_test13
#--------------------
#DATASOURCE=centeredgetest1
#CATALOG=centeredge_documentation
#--------------------
#DATASOURCE=v13testing
#CATALOG=alternate_CEtest
#CATALOG=alternate_CEtest_DBWipe
#--------------------
#DATASOURCE=ppserver2,1433
#CATALOG=pathfinder
#--------------------

TRAINING=TRAINING
PERSISTSECURITY=FALSE
WORKSTATION=ROB-PC
SQLDEPENDENCY=0
PACKETSIZE=4096
INTEGRATEDSECURITY=0
PASSWORDENCRYPTION=0

[INFO]
STATIONNO=1
REPORTPATH=C:\VISUAL STUDIO PROJECTS\DEVELOPMENT\MAIN\REPORTS


         * */
        public void Dispose()
        {
            
        }
    }
}
