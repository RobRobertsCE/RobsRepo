using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassBuilder.Data;
using ClassBuilder.Models;

namespace ClassBuilder.Mappers
{
    internal static class MemberMapper
    {
        internal static ClassMemberModel ToModel(IMember member)
        {
            ClassMemberModel model = new ClassMemberModel();

            model.ClassMemberKey = member.MemberKey;
            model.Name = member.Name;

            return model;
        }

        internal static IMember ToMember(ClassMemberModel model)
        {
            IMember member = new MemberBase();

            member.MemberKey = model.ClassMemberKey;
            member.Name = model.Name;

            return member;
        }
    }
}
