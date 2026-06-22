using System;
using FromTheRoof.Class;
using FromTheRoof.Interface;

namespace FromTheRoof.Effects;

public class StatEffectMotivation : IStrategyEffect
{
    public void ApplyEffect(Player player, double value)
    {
        player.Stats.ModifyMotivation((int)value);
    }
        public string GetDescription(double value)
    {
        return $"{value:+#;-#} Motivation";
    }
}
