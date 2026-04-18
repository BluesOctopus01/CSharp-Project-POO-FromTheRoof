using System;

namespace FromTheRoof.Class;

public class SkillEffect : Effect
{
    private string _skillName;

    public SkillEffect(int value, string description, string skillName)
        : base(value, description)
    {
        _skillName = skillName;
    }

    public override void Apply(Player player)
    {
        throw new NotImplementedException("Apply n'est pas encore implémenter");
    }
}