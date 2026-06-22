using System;
using FromTheRoof.Class;
using FromTheRoof.Interface;

namespace FromTheRoof.StatEffect;

public class StatEffectMotivation : IStrategyEffect
{
    public void ApplyEffect(Player player, double value)
    {
        player.Stats.ModifyMotivation((int)value);
    }
}
