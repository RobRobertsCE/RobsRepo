using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MockPosServer
{
    internal class FileService : SecoaService
    {
        #region constants
        private const string FileServiceName = "Secoa File Service";
        private const string WatcherFiler = @"POS_*.Req";
        #endregion

        #region fields
        private FileSystemWatcher _watcher = null;
        #endregion

        #region properties
        public override string ServiceName
        {
            get { return FileServiceName; }
        }

        private string _commandDirectory = String.Empty;
        public string CommandDirectory
        {
            get
            {
                return _commandDirectory;
            }
            set
            {
                _commandDirectory = value;
            }
        }
        #endregion

        #region ctor
        public FileService(string commandDirectory)
        {
            this.CommandDirectory = commandDirectory;
        }
        #endregion

        #region start/stop watcher
        protected internal override void Start()
        {
            ResetWatcher();

            _watcher.EnableRaisingEvents = true;
        }
        protected internal override void Stop()
        {
            ClearWatcher();
        }
        void ResetWatcher()
        {
            ClearWatcher();

            _watcher = new FileSystemWatcher(CommandDirectory);
            _watcher.Filter = WatcherFiler;
            _watcher.Renamed += _watcher_Renamed;
            _watcher.Created += _watcher_Created;
            _watcher.Changed += _watcher_Changed;
            _watcher.Error += _watcher_Error;
        }
        void ClearWatcher()
        {
            if (null != _watcher)
            {
                _watcher.EnableRaisingEvents = false;
                _watcher.Created -= _watcher_Created;
                _watcher.Changed -= _watcher_Changed;
                _watcher.Error -= _watcher_Error;
                _watcher.Renamed -= _watcher_Renamed;
                _watcher.Dispose();
            }
        }
        #endregion

        #region process command file
        void _watcher_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("File Renamed: " + e.Name);
            this.ProcessCommandFile(e.FullPath);
        }
        void ProcessCommandFile(string commandFileName)
        {
            System.Threading.Thread.Sleep(500);

            string commandFileData = GetCommandFileData(commandFileName)
            string opName = GetOpName(commandFileData);
            string responseData = ResponseFactory.GetResponse(opName);

            WriteResponseFile(commandFileName, responseData);
            DeleteCommandFile(commandFileName);
        }
        string GetCommandFileData(string commandFileName)
        {
            string commandFileData = File.ReadAllText(commandFileName);
            base.OnDataReceived(ServiceName, commandFileName, commandFileData);
            return commandFileData;
        }
        string GetOpName(string commandFileData)
        {
            string[] values = commandFileData.Split(',');
            string opName = values[1].Trim();
            return opName;
        }
        void WriteResponseFile(string commandFileName, string responseData)
        {
            string responseFileName = commandFileName.Substring(0, commandFileName.Length - 4) + ".Ack";
            System.IO.File.WriteAllText(responseFileName, responseData);
            base.OnDataReceived(ServiceName, responseFileName, responseData);
        }
        void DeleteCommandFile(string commandFileName)
        {
            System.IO.File.Delete(commandFileName);
        }
        #endregion

        #region watcher debug events
        void _watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File Changed: " + e.Name + "  Change Type: " + e.ChangeType.ToString());
        }
        void _watcher_Error(object sender, ErrorEventArgs e)
        {
            Console.WriteLine("File Watcher Error: " + e.ToString());
        }
        void _watcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File Created: " + e.Name);
        }
        #endregion
    }
}
