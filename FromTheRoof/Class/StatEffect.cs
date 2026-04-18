using System;

namespace FromTheRoof.Class;

public class StatEffect : Effect
{
    private string _statName;

    public StatEffect(int value, string description, string statName)
        : base(value, description)
    {
        _statName = statName;
    }

    public override void Apply(Player player)
    {
        throw new NotImplementedException("Apply n'est pas encore implémenter");
    }
}