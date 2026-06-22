using System;
using FromTheRoof.Class;
using FromTheRoof.Interface;

namespace FromTheRoof.Effects;

public class StatEffectStress : IStrategyEffect
{
    public void ApplyEffect(Player player, double value)
    {
    player.Stats.ModifyStress((int)value);
    }

    public string GetDescription(double value)
    {
        return $"{value:+#;-#} Stress";
    }
}
