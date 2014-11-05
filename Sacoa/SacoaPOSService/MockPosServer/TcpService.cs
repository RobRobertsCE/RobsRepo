using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MockPosServer
{
    internal class TcpService : SecoaService
    {
        private const string TcpServiceName = "Secoa Tcp Service";
        private const string TestServer = "200.80.220.106";
        private const int TestPort = 14434;

        private string server;
        private int port;

        public override string ServiceName
        {
            get { return TcpServiceName; }
        }

        public TcpService()
            : this(TestServer, TestPort)
        {

        }

        public TcpService(string server, int port)
        {
            this.server = server;
            this.port = port;
        }

        protected internal override void Start()
        {
            OpenEndpoint();
        }
        void OpenEndpoint()
        {

        }

        protected internal override void Stop()
        {
            CloseEndpoint();
        }
        void CloseEndpoint()
        {

        }
    }
}
