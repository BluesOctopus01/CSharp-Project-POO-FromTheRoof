using System;
using FromTheRoof.Class;

namespace FromTheRoof.Interface;

public interface IStrategyEffect
{
    void ApplyEffect(Player player, double value);
}
