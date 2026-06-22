using FromTheRoof.Class;
using FromTheRoof.Effects;

namespace FromTheRoof.Init;

public static class CourseInitializer
{
    public static List<Course> CreateWeeklyCourses()
    {
        return new List<Course>
        {
            new Course(
                "C# Fundamentals",
                20,
                new List<Effect>
                {
                    new Effect(2, new SkillEffect("C#")),
                    new Effect(10, new StatEffectStress()),
                    new Effect(-5, new StatEffectMotivation())
                },
                new QuizQuestion(
                    "What is a class in C#?",
                    new List<string>
                    {
                        "A blueprint used to create objects",
                        "A CSS file",
                        "A sandwich with methods",
                        "A database table"
                    },
                    0,
                    2,
                    "C#"
                )
            ),

            new Course(
                "Advanced SQL",
                20,
                new List<Effect>
                {
                    new Effect(2, new SkillEffect("SQL")),
                    new Effect(10, new StatEffectStress()),
                    new Effect(-5, new StatEffectMotivation())
                },
                new QuizQuestion(
                    "What does SQL stand for?",
                    new List<string>
                    {
                        "Structured Query Language",
                        "Simple Question List",
                        "Super Quick Lasagna",
                        "System Queue Logic"
                    },
                    0,
                    2,
                    "SQL"
                )
            ),

            new Course(
                "Web Development Workshop",
                20,
                new List<Effect>
                {
                    new Effect(2, new SkillEffect("Web")),
                    new Effect(10, new StatEffectStress()),
                    new Effect(-5, new StatEffectMotivation())
                },
                new QuizQuestion(
                    "What does HTML do?",
                    new List<string>
                    {
                        "Structures web pages",
                        "Controls electricity",
                        "Makes coffee faster",
                        "Stores passwords in RAM"
                    },
                    0,
                    2,
                    "Web"
                )
            ),

            new Course(
                "Network Infrastructure",
                20,
                new List<Effect>
                {
                    new Effect(2, new SkillEffect("Network")),
                    new Effect(10, new StatEffectStress()),
                    new Effect(-5, new StatEffectMotivation())
                },
                new QuizQuestion(
                    "What is an IP address?",
                    new List<string>
                    {
                        "An identifier for a device on a network",
                        "A gaming keyboard",
                        "A secret pizza recipe",
                        "A monitor resolution"
                    },
                    0,
                    2,
                    "Network"
                )
            ),

            new Course(
                "Cybersecurity Basics",
                20,
                new List<Effect>
                {
                    new Effect(2, new SkillEffect("Cybersecurity")),
                    new Effect(15, new StatEffectStress()),
                    new Effect(-10, new StatEffectMotivation())
                },
                new QuizQuestion(
                    "What is phishing?",
                    new List<string>
                    {
                        "A scam used to steal information",
                        "A type of antivirus",
                        "Fishing with a laptop",
                        "A gaming strategy"
                    },
                    0,
                    2,
                    "Cybersecurity"
                )
            ),

            new Course(
                "Python Automation",
                20,
                new List<Effect>
                {
                    new Effect(2, new SkillEffect("Python")),
                    new Effect(10, new StatEffectStress()),
                    new Effect(-5, new StatEffectMotivation())
                },
                new QuizQuestion(
                    "What is Python mainly used for?",
                    new List<string>
                    {
                        "Programming and automation",
                        "Cooking recipes",
                        "Talking to snakes",
                        "Repairing roofs"
                    },
                    0,
                    2,
                    "Python"
                )
            )
        };
    }
}