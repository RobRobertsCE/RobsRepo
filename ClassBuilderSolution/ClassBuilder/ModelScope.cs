using System;

namespace ClassBuilder
{
    [Flags()]
    public enum ModelScope
    {
        None = 0,
        Public = 1,
        Friend = 2,
        Sealed = 4,
        Abstract = 6,
        Private = 8
    }
}
