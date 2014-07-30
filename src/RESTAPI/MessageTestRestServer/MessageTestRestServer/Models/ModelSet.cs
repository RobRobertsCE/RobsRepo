using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdvantageMessaging.Data;
using AdvantageMessaging.Service.Models;

namespace MessageTestRestServer.Models
{
    public class ModelSet
    {
        //Messages
        IList<MessageModel> messages = null;

        void BuildModel()
        {
            messages = new List<MessageModel>();

            messages.Add(GetMessage(0));
        }

        MessageModel GetMessage(int idx)
        {
            MessageModel model = new MessageModel();

            model.MessageId = Guid.NewGuid();
            model.Subject = "Message #" + idx.ToString();
            model.Body = "Message Body Here";
            model.LastUpdate = DateTime.Now.AddDays(-1);

            return model;
        }

        MessageScheduleModel GetSchedule(int idx)
        {
            MessageScheduleModel schedule = new MessageScheduleModel();
            schedule.Expires = DateTime.Now.AddDays(7);

            return schedule;
        }
    }
}

