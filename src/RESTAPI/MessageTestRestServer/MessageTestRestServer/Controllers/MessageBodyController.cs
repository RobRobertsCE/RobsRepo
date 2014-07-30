using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using AdvantageMessaging.Service.Models;

namespace MessageTestRestServer.Controllers
{
    public class MessageBodyController : ApiController
    {
        // GET api/messagebody
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/messagebody/5
        public HttpResponseMessage Get(string id)
        {
            MessageApiBaseModel<MessageBodyResponseModel> model = new MessageApiBaseModel<MessageBodyResponseModel>();

            MessageBodyResponseModel response = new MessageBodyResponseModel();
            response.messageId = Guid.Parse(id);
            response.body = "<HTML><BODY>Hello World!</BODY></HTML>";

            List<MessageBodyResponseModel> list = new List<MessageBodyResponseModel>();

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

        // POST api/messagebody
        public void Post([FromBody]string value)
        {
        }

        // PUT api/messagebody/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/messagebody/5
        public void Delete(int id)
        {
        }
    }
}
