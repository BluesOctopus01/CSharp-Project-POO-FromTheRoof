using System;
using FromTheRoof.Interface;

namespace FromTheRoof.Class;

public class SkillEffect : IStrategyEffect
{
    private string _skillName;

    public SkillEffect(string skillName)
    {
        _skillName = skillName;
    }
    public void ApplyEffect(Player player, int value)
    {
        throw new NotImplementedException();
    }


}