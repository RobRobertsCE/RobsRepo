using System;

namespace ClassBuilder
{
    [Flags()]
    public enum MemberType
    {   
        None=0,
        Field = 1,
        Property = 2
    }
}
