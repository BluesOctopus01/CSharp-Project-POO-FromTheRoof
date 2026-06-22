namespace FromTheRoof.Class;

public class Exam
{
    private string _name;

    public Exam(string name)
    {
        _name = name;
    }

    public int CalculateScore(Player player)
    {
        int score = 0;

        foreach (Skill skill in player.Skills)
        {
            score += skill.Level * 10;
        }

        if (player.Stats.IsMotivated)
        {
            score += 10;
        }

        if (player.Stats.IsBurnedOut || player.Stats.IsBroke || player.Stats.IsExhausted)
        {
            score -= 50;
        }

        return Math.Clamp(score, 0, 100);
    }

    public void DisplayResult(Player player)
    {
        int score = CalculateScore(player);

        Console.WriteLine();
        Console.WriteLine($"=== {_name.ToUpper()} ===");
        Console.WriteLine();

        Console.WriteLine($"Final Score : {score}/100");

        if (score >= 60)
        {
            Console.WriteLine("You passed the exam.");
        }
        else
        {
            Console.WriteLine("You failed the exam.");
        }
    }
}