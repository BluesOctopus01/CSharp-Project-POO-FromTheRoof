using FromTheRoof.Ui;

namespace FromTheRoof.Class;

public class QuizQuestion
{
    private string _question;
    private List<string> _answers;
    private int _correctAnswerIndex;
    private int _stupidAnswerIndex;
    private string _skillName;

    public QuizQuestion(
        string question,
        List<string> answers,
        int correctAnswerIndex,
        int stupidAnswerIndex,
        string skillName)
    {
        _question = question;
        _answers = answers;
        _correctAnswerIndex = correctAnswerIndex;
        _stupidAnswerIndex = stupidAnswerIndex;
        _skillName = skillName;
    }

    public bool Ask(Player player)
    {
        GameUi.ShowSection("Quiz");
        Console.WriteLine(_question);
        Console.WriteLine();

        for (int i = 0; i < _answers.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_answers[i]}");
        }

        Console.Write("Answer : ");
        string input = Console.ReadLine() ?? "";

        if (!int.TryParse(input, out int choice))
        {
            Console.WriteLine("Invalid answer.");
            player.Stats.ModifyStress(10);
            return false;
        }

        int index = choice - 1;

        if (index == _correctAnswerIndex)
        {
            Console.WriteLine("Correct answer. You gain +1 skill point.");

            Skill? skill = player.GetSkillByName(_skillName);

            if (skill != null)
            {
                skill.IncreaseLevel(1);
            }

            return true;
        }

        if (index == _stupidAnswerIndex)
        {
            Console.WriteLine("Terrible answer. The whole class laughs at you...");
            player.Stats.ModifyStress(25);
        }
        else
        {
            Console.WriteLine("Wrong answer.");
            player.Stats.ModifyStress(15);
        }

        return false;
    }
}