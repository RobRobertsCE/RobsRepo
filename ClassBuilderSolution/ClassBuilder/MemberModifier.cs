using System;

namespace ClassBuilder
{
    [Flags()]
    public enum MemberModifier
    {
        None = 0,
        Overridable = 1,
        Overrides = 2,
        MustOverride = 4,
        Implements = 8
    }
}
