using FromTheRoof.Class;

class Program
{
    static void Main(string[] args)
    {
        // StatSheet
        StatSheet stats = new StatSheet(100, 50, 0, 25.0);

        // Skills (liste vide pour l’instant)
        List<Skill> skills = new List<Skill>();

        // Player
        Player player = new Player("Thomas", stats, skills);

        // Effects
        Effect statEffect = new StatEffect(10, "Gain energy", "energy");
        Effect skillEffect = new SkillEffect(5, "Gain skill", "C#");

        List<Effect> effects = new List<Effect> { statEffect, skillEffect };

        // Event
        Event gameEvent = new Event("Small Boost", "You feel productive", 50, effects);

        // Exams (liste vide)
        List<Exam> exams = new List<Exam>();

        // Courses (liste vide)
        List<Course> courses = new List<Course>();

        // Year
        Year year = new Year(1, exams, courses);

        // Day (dummy — adapte selon ton constructeur réel)
        Day day = new Day();

        // Simulation
        Simulation simulation = new Simulation(player, day, year, true);

        Console.WriteLine("Squelette opérationnel.");
    }
}