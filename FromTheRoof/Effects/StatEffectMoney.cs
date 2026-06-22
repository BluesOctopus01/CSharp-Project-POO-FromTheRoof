using System;
using FromTheRoof.Class;
using FromTheRoof.Interface;

namespace FromTheRoof.Effects;

public class StatEffectMoney : IStrategyEffect
{
    public void ApplyEffect(Player player, double value)
    {
        player.Stats.ModifyMoney(value);
    }
    public string GetDescription(double value)
    {
        return $"{value:+#;-#} Money";
    }
}
