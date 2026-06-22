using System;
using FromTheRoof.Interface;
using FromTheRoof.Class;
namespace FromTheRoof.Class;

public class Effect
{
    private int _value;

    private IStrategyEffect _strategy;

    public Effect(int value, IStrategyEffect strategy)
    {
        _value = value;
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