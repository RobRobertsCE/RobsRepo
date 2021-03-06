﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MockPosServer
{
    public partial class Form1 : Form
    {
        private const string CommandDirectory = @"C:\Secoa";

        private enum ServerState
        {
            None = 0,
            Ready = 1,
            Started = 2,
            Busy = 3,
            Error = 4
        }

        private ServerState _state = ServerState.None;
        private FileService _fileServer = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display("Ready");
            _state = ServerState.Ready;
        }

        void Display(string message)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtDisplay.AppendText(String.Format("[{0}]  {1}{2}", DateTime.Now, message, Environment.NewLine));
            });            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartServer();
        }
        void StartServer()
        {
            InitializeFileService();
            _fileServer.Start();

            Display("Server started");
            _state = ServerState.Started;
        }
        void InitializeFileService()
        {
            DisposeFileService();

            _fileServer = new FileService(CommandDirectory);
            _fileServer.DataSent += _fileServer_DataSent;
            _fileServer.DataReceived += _fileServer_DataReceived;
        }
        void DisposeFileService()
        {
            if (null != _fileServer)
            {
                _fileServer.Stop();
                _fileServer.DataSent -= _fileServer_DataSent;
                _fileServer.DataReceived -= _fileServer_DataReceived;
                _fileServer = null;
            }
        }

        void _fileServer_DataReceived(object sender, string serviceName, string fileName, string data)
        {
            Display(String.Format("Data Received -> Service:{0} File:{1} Data:{2}", serviceName, fileName, data));
        }

        void _fileServer_DataSent(object sender, string serviceName, string fileName, string data)
        {
            Display(String.Format("Data Sent -> Service:{0} File:{1} Data:{2}", serviceName, fileName, data));
        }
        
        private void btnStop_Click(object sender, EventArgs e)
        {
            StopServer();
        }
        void StopServer()
        {

            DisposeFileService();

            Display("Server stopped");
            _state = ServerState.Ready;
        }

    }
}
