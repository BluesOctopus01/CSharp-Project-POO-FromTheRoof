using System;
using FromTheRoof.Class;
using FromTheRoof.Effects;

namespace FromTheRoof.Init;

public static class CourseInitializer{
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
            }
        ),

        new Course(
            "Advanced SQL",
            20,
            new List<Effect>
            {
                new Effect(2, new SkillEffect("SQL")),
                new Effect(10, new StatEffectStress()),
                new Effect(-5, new StatEffectMotivation())
            }
        ),

        new Course(
            "Web Development Workshop",
            20,
            new List<Effect>
            {
                new Effect(2, new SkillEffect("Web")),
                new Effect(10, new StatEffectStress()),
                new Effect(-5, new StatEffectMotivation())
            }
        ),

        new Course(
            "Network Infrastructure",
            20,
            new List<Effect>
            {
                new Effect(2, new SkillEffect("Network")),
                new Effect(10, new StatEffectStress()),
                new Effect(-5, new StatEffectMotivation())
            }
        ),

        new Course(
            "Cybersecurity Basics",
            20,
            new List<Effect>
            {
                new Effect(2, new SkillEffect("Cybersecurity")),
                new Effect(15, new StatEffectStress()),
                new Effect(-10, new StatEffectMotivation())
            }
        )
    };
}
}