using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassBuilder
{
    public class ModelModifier : ClassBuilder.IModelModifier
    {
        public ModelModifierType ModelModifierType { get; set; }
    }
}
