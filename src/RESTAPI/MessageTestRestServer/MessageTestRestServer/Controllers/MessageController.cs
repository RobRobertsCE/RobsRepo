using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using AdvantageMessaging.Service.Models;

using AdvantageMessaging.Service.Models;

namespace MessageTestRestServer.Controllers
{
    public class MessageController : ApiController
    {
        // GET api/message
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/message/5
        public HttpResponseMessage Get(string id)
        {
            MessageApiBaseModel<MessageListResponseModel> model = new MessageApiBaseModel<MessageListResponseModel>();
            
            MessageListResponseModel response = null;

            List<MessageListResponseModel> list = new List<MessageListResponseModel>();

            response = new MessageListResponseModel();

            response.expires = DateTime.Now.AddDays(2);
            response.lastUpdate = DateTime.Now.AddDays(-1);
            response.messageId = Guid.NewGuid();
            response.messageScheduleId = Guid.NewGuid();
            response.subject = "I've got something in my pocket for you...";
            
            list.Add(response);

            response = new MessageListResponseModel();

            response.expires = DateTime.Now.AddDays(3);
            response.lastUpdate = DateTime.Now.AddDays(-2);
            response.messageId = Guid.NewGuid();
            response.messageScheduleId = Guid.NewGuid();
            response.subject = "Why HELLLOOOOOO there!";

            list.Add(response);

            model.results = list;
            model.count = list.Count;

            string serialized = Newtonsoft.Json.JsonConvert.SerializeObject(model);

            var resp = new HttpResponseMessage()
            {
                Content = new StringContent(serialized)
            };

            resp.Content.Headers.ContentType =
                          new MediaTypeHeaderValue("application/json");


            return resp;
        }

        // POST api/message
        public void Post([FromBody]string value)
        {
        }

        // PUT api/message/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/message/5
        public void Delete(int id)
        {
        }
    }
}
