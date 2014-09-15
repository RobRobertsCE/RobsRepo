using System;
namespace ClassBuilder
{
    public interface IDTObject
    {
        System.Collections.Generic.IList<IMember> Members { get; set; }
        string Name { get; set; }
    }
}
