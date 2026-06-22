using System;
using FromTheRoof.Class;
using FromTheRoof.Interface;

namespace FromTheRoof.Effects;

public class StatEffectEnergy : IStrategyEffect
{
    public void ApplyEffect(Player player, double value)
    {
        player.Stats.ModifyEnergy((int)value);
    }
    public string GetDescription(double value)
    {
        return $"{value:+#;-#} Energy";
    }
}
