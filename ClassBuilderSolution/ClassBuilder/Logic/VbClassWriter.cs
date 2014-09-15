using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassBuilder.Logic
{
    public class VbClassWriter : ClassWriter
    {
        public VbClassWriter()
            : base(new VbMemberWriter())
        {
        }
    }
}
