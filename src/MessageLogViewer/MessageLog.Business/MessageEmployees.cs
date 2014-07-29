using MessageLog.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLog.Business
{
    public static class MessageEmployees
    {
        public static List<int?> GetEmployeeNumberList(string connectionString)
        {
            using (MessageLogContext ctx = new MessageLogContext(connectionString))
            {
                return ctx.MessageLogs.Select(m => m.EmpNo.HasValue ? m.EmpNo : 0).Distinct().ToList();
            }
        }
    }
}
