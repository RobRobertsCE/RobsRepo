using System;
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
        private enum ServerState
        {
            None = 0,
            Ready = 1,
            Started = 2,
            Busy = 3,
            Error = 4
        }

        private ServerState _state = ServerState.None;

        public Form1()
        {
            InitializeComponent();

            Display("Ready");
            _state = ServerState.Ready;
        }

        void Display(string message)
        {
            txtDisplay.AppendText(String.Format("[{0}]  {1}{2}",DateTime.Now, message, Environment.NewLine));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartServer();
        }
        void StartServer()
        {
            Display("Server started");
            _state = ServerState.Started;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopServer();
        }
        void StopServer()
        {
            Display("Server stopped");
            _state = ServerState.Ready;
        }
    }
}
