using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvantageMessaging.Service.Models;
using System.Net;

namespace MessagingRESTAPITextClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void statRequestButton_Click(object sender, EventArgs e)
        {
            this.TestMessageStats();
        }

        private void TestMessageStats()
        {
            try
            {
                string url = GetBaseURL() + Guid.NewGuid().ToString(); ;

                WebRequest request = WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/json";

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    MessageStatRequestModel model = GetMessageStatsModel();

                    string json = Newtonsoft.Json.JsonConvert.SerializeObject(model);

                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();

                }

                var httpResponse = (HttpWebResponse)request.GetResponse();
                HandleResponse(httpResponse);

              
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
      
        }

        private MessageStatRequestModel GetMessageStatsModel()
        {
            MessageStatRequestModel model = new MessageStatRequestModel();

            MessageLocationModel locationModel = new MessageLocationModel();

            locationModel.locationHash = "ABC123";

            MessageViewerModel viewer = new MessageViewerModel();

            viewer.empName = "Joe Employee";
            viewer.empNo = 168;
            viewer.viewed = DateTime.Now;

            locationModel.readBy = new List<MessageViewerModel>() { viewer };

            model.locations = new List<MessageLocationModel>() { locationModel };

            return model;
        }

        string GetBaseURL()
        {
            return "http://localhost:52078/api/messagestats/";
        }

        void HandleResponse(HttpWebResponse response)
        {
            OutputMessage("Status: " + response.StatusDescription);

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                HandleResult(result);
            }
        }

        void HandleResult(string result)
        {
            OutputMessage(" :: BEGIN RESULT :: ");
            OutputMessage(result);
            OutputMessage(" :: END RESULT :: ");
        }

        void HandleException(Exception ex)
        {
            DisplayMessage(ex.Message);
            OutputMessage(ex.ToString());
        }

        void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }

        void OutputMessage(string message)
        {
            outputText.Text += message + Environment.NewLine;

            outputText.ScrollToCaret();
        }
    }
}
