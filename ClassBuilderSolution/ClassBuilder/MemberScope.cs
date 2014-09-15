using System;

namespace ClassBuilder
{
    [Flags()]
    public enum MemberScope
    {
        None = 0,
        Public = 1,
        Friend = 2,
        Protected = 4,
        ProtectedFriend = 6,
        Private = 8
    }
}
