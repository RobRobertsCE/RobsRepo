using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLog.Data
{
    using System;
    using System.Collections.Generic;

    public partial class MessageLogContext
    {
        public MessageLogContext(string connectionString)
            : base(connectionString)
        {

        }
    }
}