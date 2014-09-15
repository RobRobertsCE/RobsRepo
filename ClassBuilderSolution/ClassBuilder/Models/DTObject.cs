using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassBuilder.Models
{
    public class DTObject : IDTObject
    {
        public int DTObjectKey { get; set; }

        public string Name { get; set; }

        public string ModelNamespace { get; set; }

        public MemberScope ModelScope { get; set; }

        public ModelType ModelType { get; set; }

        public IList<IMember> Members { get; set; }

        public IList<IModelModifier> Modifiers { get; set; }

        public IList<string> ImportStatements { get; set; }

        public DTObject()
        {
            Members = new List<IMember>();
            Modifiers = new List<IModelModifier>();
            ImportStatements = new List<string>();
        }

        internal DTObject(string name)
        {
            this.Name = name;
        }

        internal DTObject(int key, string name, string modelNamespace)
        {
            this.Name = name;
        }
    }
}
