using System;
namespace ClassBuilder
{
    public interface IModelModifier
    {
        ModelModifierType ModelModifierType { get; set; }
    }
}
