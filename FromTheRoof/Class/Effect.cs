using System;

namespace FromTheRoof.Class;

public class Effect
{
    protected int _value;
    protected string _description;

    protected Effect(int value, string description)
    {
        _value = value;
        _description = description;
    }

    public virtual void Apply(Player player)
    {
        throw new NotImplementedException("Apply n'est pas encore implémenter");
    }
}