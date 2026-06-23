namespace FromTheRoof.Class;

public class Exam
{
    private string _name;
    private int _scoreExam = 0;

    public Exam(string name)
    {
        _name = name;
    }

    public int CalculateScore(Player player)
    {
        foreach (Skill skill in player.Skills)
        {
            _scoreExam += skill.Level * 10;
        }

        if (player.Stats.IsMotivated)
        {
            _scoreExam += 10;
        }

        if (player.Stats.IsBurnedOut || player.Stats.IsBroke || player.Stats.IsExhausted)
        {
            _scoreExam -= 50;
        }

        return Math.Clamp(_scoreExam, 0, 100);
    }

    public void DisplayResult(Player player)
    {
        int _scoreExam = CalculateScore(player);

        Console.WriteLine();
        Console.WriteLine($"=== {_name.ToUpper()} ===");
        Console.WriteLine();

        Console.WriteLine($"Final Score : {_scoreExam}/100");

        if (_scoreExam >= 60)
        {
            Console.WriteLine("You passed the exam.");
        }
        else
        {
            Console.WriteLine("You failed the exam.");
        }
    }
}