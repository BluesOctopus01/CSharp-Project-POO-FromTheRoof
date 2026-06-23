using FromTheRoof.Ui;

namespace FromTheRoof.Class;

public class Course
{
    private string _name;
    private int _minEnergyRequired;
    private List<Effect> _effects;
    private QuizQuestion _question;
    public Course(string name, int minEnergyRequired,List<Effect> effects,QuizQuestion question)
    {
        _name = name;
        _minEnergyRequired = minEnergyRequired;
        _effects = effects;
        _question = question;
    }
    public string Name => _name;
    public bool CanBeAttendedBy(Player player)
    {
        return player.Stats.Energy >= _minEnergyRequired;
    }
    public void Attend(Player player)
    {
        if (!CanBeAttendedBy(player))
        {
            Console.WriteLine("You are too tired to attend this course.");
            return;
        }

        GameUi.ShowSection($"COURSE : {Name}");
        Console.WriteLine("You attend the course.");

        foreach (Effect effect in _effects)
        {
            effect.Apply(player);
        }

        Console.WriteLine("You gained the regular course benefits.");
        GameUi.ShowSeparator();
        Console.WriteLine("Before you left the class, the teacher ask you a question...");

        _question.Ask(player);
    }


}