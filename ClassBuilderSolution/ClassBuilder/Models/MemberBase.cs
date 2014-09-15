using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassBuilder.Models
{
    public class MemberBase : ClassBuilder.IMember
    {
        public int MemberKey { get; set; }

        public string Name { get; set; }

        public Type Type { get; set; }

        public MemberScope MemberScope { get; set; }

        public MemberModifier MemberModifier { get; set; }

        public MemberType MemberType { get; set; }

        public MemberBase()
        {

        }

        public MemberBase(string name, Type type)
        {
            this.Name = name;
            this.Type = type;
        }

        internal MemberBase(int key, string name, Type type)
        {
            this.MemberKey = key;
            this.Name = name;
            this.Type = type;
        }
    }
}
