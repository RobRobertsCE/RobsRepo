using MessageLog.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLog.Business
{
    public static class MessageStations 
    {
        public static List<int?> GetStationList(string connectionString)
        {
            using (MessageLogContext ctx = new MessageLogContext(connectionString))
            {
                return ctx.MessageLogs.Select(m => m.StationNo.HasValue ? m.StationNo : 0).Distinct().ToList();
            }
        }
    }
}
