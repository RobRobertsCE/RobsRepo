using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MockPosServer
{
    public delegate void DataReceivedHandler(object sender, string serviceName, string fileName, string data);

    public delegate void DataSentHandler(object sender, string serviceName, string fileName, string data);

    public delegate void ServerStartedHandler(object sender, string service);

    public delegate void ServerStoppedHandler(object sender, string service);
    
}
