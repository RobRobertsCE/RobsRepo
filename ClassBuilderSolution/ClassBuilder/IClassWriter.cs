using System;
using System.Collections.Generic;

namespace ClassBuilder
{
    public interface IClassWriter
    {
        string BuildClass(IDTObject model);
    }
}
