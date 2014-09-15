using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassBuilder.Logic
{
    public class VbMemberWriter : ClassBuilder.IMemberWriter
    {
        private const string IndentSpace = "    ";

        public VbMemberWriter()
        {
        }

        public string BuildMember(IMember member, StringBuilder sb)
        {
            sb.AppendFormat("{0}{1} ", IndentSpace, member.MemberScope.ToString());
            
            if (!member.MemberModifier.HasFlag(MemberModifier.None))
            {
                sb.AppendFormat("{0} ", member.MemberModifier.ToString());
            }

            if (member.MemberType.HasFlag(MemberType.Property))
            {
                sb.AppendFormat("Property {0}() ", member.Name.ToString());
            }
            else
            {
                sb.AppendFormat("{0} ", member.Name.ToString());
            }
            
            sb.AppendFormat("As {0}", member.Type.FullName.ToString());
            
            return sb.ToString();
        }
    }
}
