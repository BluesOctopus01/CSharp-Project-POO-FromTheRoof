using FromTheRoof.Interface;

namespace FromTheRoof.Effects;
using FromTheRoof.Class;

public class RandomSkillEffect : IStrategyEffect
{
    private static Random _random = new Random();

    public void ApplyEffect(Player player, double value)
    {
        int randomIndex = _random.Next(0, player.Skills.Count);
        Skill randomSkill = player.Skills[randomIndex];
        randomSkill.IncreaseLevel((int)value);
        Console.WriteLine($"{randomSkill.Name} increased !");
    }

    public string GetDescription(double value)
    {
        return $"{value:+#;-#} Random Skill";
    }
}