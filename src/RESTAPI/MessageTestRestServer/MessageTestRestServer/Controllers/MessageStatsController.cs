using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AdvantageMessaging.Service.Models;

namespace MessageTestRestServer.Controllers
{
    public class MessageStatsController : ApiController
    {
        // GET api/messagestats
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/messagestats/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/messagestats
        public HttpResponseMessage Post(System.Guid id, [FromBody]MessageStatRequestModel model)
        {

            var resp = new HttpResponseMessage()
            {
                Content = new StringContent(model.locations[0].locationHash)
            };

            resp.StatusCode = HttpStatusCode.OK;

            return resp;
        }

        // PUT api/messagestats/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/messagestats/5
        public void Delete(int id)
        {
        }
    }
}
