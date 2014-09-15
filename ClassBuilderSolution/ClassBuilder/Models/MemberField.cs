using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassBuilder.Models
{
    public class MemberField : MemberBase
    {
        public MemberField(string name, Type type)
            : base(name, type)
        {
            this.MemberScope = ClassBuilder.MemberScope.Private;
            this.MemberType = ClassBuilder.MemberType.Field;
        }
    }
}
