using MessageLog.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLog.Business
{
    public class MessageLogEntry
    {
        public System.Guid ID { get; set; }
        public System.DateTime Timestamp { get; set; }
        public int Station { get; set; }
        public string ProgramName { get; set; }
        public int EmployeeNumber { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public bool ErrorMessage { get; set; }

        public MessageLogEntry()
        {

        }

        public MessageLogEntry(MessageLog.Data.MessageLog entry)
        {
            this.ID = entry.MsgID;
            this.Timestamp = (true == entry.MsgDateTime.HasValue) ? entry.MsgDateTime.Value : DateTime.MinValue;
            this.Station = (true == entry.StationNo.HasValue) ? entry.StationNo.Value : 0;
            this.ProgramName = entry.ProgramName;
            this.EmployeeNumber = (true == entry.EmpNo.HasValue) ? entry.EmpNo.Value : 0;
            this.Message = entry.MessageText;
            this.StackTrace = entry.StackTrace;
            this.ErrorMessage = entry.Error;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format("{0}:{1}{2}", "ID", ID.ToString(), Environment.NewLine));
            sb.AppendLine(String.Format("{0}:{1}{2}", "Timestamp", Timestamp.ToString(), Environment.NewLine));
            sb.AppendLine(String.Format("{0}:{1}{2}", "ErrorMessage", ErrorMessage.ToString(), Environment.NewLine));
            sb.AppendLine(String.Format("{0}:{1}{2}", "Station", Station.ToString(), Environment.NewLine));
            sb.AppendLine(String.Format("{0}:{1}{2}", "ProgramName", ProgramName.ToString(), Environment.NewLine));
            sb.AppendLine(String.Format("{0}:{1}{2}", "EmployeeNumber", EmployeeNumber.ToString(), Environment.NewLine));
            sb.AppendLine(String.Format("{0}:{1}{2}", "Message", Message.ToString(), Environment.NewLine));
            sb.AppendLine(String.Format("{0}:{1}{2}", "StackTrace", StackTrace.ToString(), Environment.NewLine));

            return sb.ToString();
        }
    }
}
