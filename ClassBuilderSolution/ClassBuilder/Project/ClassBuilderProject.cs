using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassBuilder.Models;

namespace ClassBuilder.Project
{
    internal class ClassBuilderProject : ClassBuilder.IProject
    {
        public int ProjectKey { get; private set; }

        public string Name { get; set; }

        public string RootNamespace { get; set; }

        public IList<IDTObject> DTObjects { get; set; }

        public ClassBuilderProject(string name, string rootNamespace)
        {
            this.Name = name;
            this.RootNamespace = rootNamespace;
            DTObjects = new List<IDTObject>();
        }

        internal ClassBuilderProject(int key, string name, string rootNamespace)
        {
            this.ProjectKey = key;
            this.Name = name;
            this.RootNamespace = rootNamespace;
            DTObjects = new List<IDTObject>();
        }
    }
}
