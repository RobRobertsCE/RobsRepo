using MessageLog.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLog.Business
{
    public static class MessagePrograms
    {
        public static List<string> GetProgramList(string connectionString)
        {
            using (MessageLogContext ctx = new MessageLogContext(connectionString))
            {
                return ctx.MessageLogs.Select(m => m.ProgramName).Distinct().ToList();
            }
        }
    }
}
