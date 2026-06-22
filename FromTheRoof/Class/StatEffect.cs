using System;
using FromTheRoof.Interface;

namespace FromTheRoof.Class;

public class StatEffect : IStrategyEffect
{
    private string _statName;

    public StatEffect(string statName)
    {
        _statName = statName;
    }
    public void ApplyEffect(Player player, int value)
    {
        throw new NotImplementedException();
    }
}