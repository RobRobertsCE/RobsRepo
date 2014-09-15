using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassBuilder.Models
{
    public class MemberProperty : MemberBase
    {
        public MemberProperty(string name, Type type)
            : base(name, type)
        {
            this.MemberScope = ClassBuilder.MemberScope.Public;
            this.MemberType = ClassBuilder.MemberType.Property;
        }
    }
}
