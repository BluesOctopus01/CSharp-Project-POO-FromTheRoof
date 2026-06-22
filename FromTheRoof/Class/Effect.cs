using System;
using FromTheRoof.Interface;

namespace FromTheRoof.Class;

public class Effect
{
    private int _value;
    private string _description;

    private IStrategyEffect _strategy;

    protected Effect(int value, string description, IStrategyEffect strategy)
    {
        _value = value;
        _description = description;
        _strategy = strategy;
    }
    public void SetStrategy(IStrategyEffect strategy)
    {
        _strategy = strategy;
    }
    public void Apply(Player player)
    {
        _strategy.ApplyEffect(player,_value);
    }
}