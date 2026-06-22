using System;
using FromTheRoof.Class;
using FromTheRoof.Interface;

namespace FromTheRoof.StatEffect;

public class StatEffectMoney : IStrategyEffect
{
    public void ApplyEffect(Player player, double value)
    {
        player.Stats.ModifyMoney(value);
    }
}
