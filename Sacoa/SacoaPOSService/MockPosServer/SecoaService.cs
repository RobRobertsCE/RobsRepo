using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MockPosServer
{
    abstract class SacoaService
    {
        #region events
        public event DataReceivedHandler DataReceived;
        protected internal void OnDataReceived(string service, string fileName, string data)
        {
            if (null != DataReceived)
            {
                DataReceived(this, service, fileName, data);
            }
        }
        public event DataSentHandler DataSent;
        protected internal void OnDataSent(string service, string fileName, string data)
        {
            if (null != DataSent)
            {
                DataSent(this, service, fileName, data);
            }
        }
        public event ServerStartedHandler ServerStarted;
        private void OnServerStarted(string serviceName)
        {
            if (null != ServerStarted)
            {
                ServerStarted(this, serviceName);
            }
        }
        public event ServerStoppedHandler ServerStopped;
        private void OnServerStopped(string serviceName)
        {
            if (null != ServerStopped)
            {
                ServerStopped(this, serviceName);
            }
        } 
        #endregion

        public abstract string ServiceName { get; }

        protected internal SacoaService()
        {

        }

        public void StartService()
        {
            Start();
            OnServerStarted(ServiceName);
        }
        protected internal abstract void Start();

        public void StopService()
        {
            Stop();
            OnServerStopped(ServiceName);
        }
        protected internal abstract void Stop();
    }
}
