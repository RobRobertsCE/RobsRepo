using System;

namespace ClassBuilder
{
    public interface IMember
    {
        MemberScope MemberScope { get; set; }
        MemberModifier MemberModifier { get; set; }
        MemberType MemberType { get; set; }
        string Name { get; set; }
        Type Type { get; set; }
        int MemberKey { get; set; }
    }
}
