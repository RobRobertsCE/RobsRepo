using MessageLog.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLog.Business
{
    public class MessageLogEntries : List<MessageLogEntry>, IDisposable
    {
        #region " fields "
        private static string efCnString = String.Empty;

        static MessageLogContext sharedDbCtx = null;

        #endregion

        #region " properties "
        public static string EfConnectionString
        {
            get
            {
                return efCnString;
            }
            set
            {
                if (efCnString != value)
                {
                    efCnString = value;
                    sharedDbCtx = null;
                }
            }
        }

        private static MessageLogContext DbContext
        {
            get
            {

                if (null == sharedDbCtx)
                {
                    if (!string.IsNullOrEmpty(EfConnectionString))
                        sharedDbCtx = new MessageLogContext(EfConnectionString);
                    else
                        sharedDbCtx = new MessageLogContext();
                }

                return sharedDbCtx;
            }
        }

        #endregion

        #region ctor
        public MessageLogEntries(IQueryable<MessageLogEntry> entries)
            : base(entries)
        {

        }

        public MessageLogEntries()
            : base()
        {

        }

        #endregion

        #region factory
        public static MessageLogEntries Entries()
        {
            return new MessageLogEntries(MessageLogEntries.GetEntries());
        }

        public static MessageLogEntries Entries(int maxCount)
        {
            return new MessageLogEntries(MessageLogEntries.GetEntries().Take(maxCount));
        }

        #endregion

        #region private methods [get all entries]
        private static IQueryable<MessageLogEntry> GetEntries()
        {
            return DbContext.MessageLogs.OrderByDescending(m => m.MsgDateTime).Select(e => new MessageLogEntry()
                {
                    ID = e.MsgID,
                    Timestamp = (true == e.MsgDateTime.HasValue) ? e.MsgDateTime.Value : DateTime.MinValue,
                    Station = (true == e.StationNo.HasValue) ? e.StationNo.Value : 0,
                    ProgramName = e.ProgramName,
                    EmployeeNumber = (true == e.EmpNo.HasValue) ? e.EmpNo.Value : 0,
                    Message = e.MessageText,
                    StackTrace = e.StackTrace,
                    ErrorMessage = e.Error
                });
        }

        #endregion

        #region IDisposable
        public void Dispose()
        {
            sharedDbCtx = null;
        }

        #endregion
    }
}
