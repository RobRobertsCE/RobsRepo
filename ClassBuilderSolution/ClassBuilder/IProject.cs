using System;
namespace ClassBuilder
{
    public interface IProject
    {
        int ProjectKey { get; }
        string Name { get; set; }
        string RootNamespace { get; set; }
        System.Collections.Generic.IList<ClassBuilder.IDTObject> DTObjects { get; set; }

    }
}
