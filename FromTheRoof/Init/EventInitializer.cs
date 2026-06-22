using FromTheRoof.Class;
using FromTheRoof.Effects;

namespace FromTheRoof.Init;

public static class EventInitializer
{
    public static List<GameEvent> CreateRandomEvents()
    {
        return new List<GameEvent>
        {
            new GameEvent(
                "Bad Night",
                "You slept very poorly.",
                20,
                new List<Effect>
                {
                    new Effect(-20, new StatEffectEnergy()),
                    new Effect(10, new StatEffectStress())
                }
            ),

            new GameEvent(
                "Motivational Video",
                "You watched an inspiring video.",
                15,
                new List<Effect>
                {
                    new Effect(20, new StatEffectMotivation())
                }
            ),

            new GameEvent(
                "Unexpected Expense",
                "Your laptop charger broke.",
                10,
                new List<Effect>
                {
                    new Effect(-25, new StatEffectMoney()),
                    new Effect(5, new StatEffectStress())
                }
            ),

            new GameEvent(
                "Hackathon Opportunity",
                "You participated in a small hackathon.",
                10,
                new List<Effect>
                {
                    new Effect(1, new RandomSkillEffect()),
                    new Effect(15, new StatEffectMotivation()),
                    new Effect(10, new StatEffectStress())
                }
            ),

            new GameEvent(
                "Coffee With Friends",
                "You had a relaxing moment with friends.",
                15,
                new List<Effect>
                {
                    new Effect(10, new StatEffectMotivation()),
                    new Effect(-10, new StatEffectStress()),
                    new Effect(-10, new StatEffectMoney())
                }
            ),

            new GameEvent(
                "System Crash",
                "Your computer crashed during work.",
                10,
                new List<Effect>
                {
                    new Effect(15, new StatEffectStress()),
                    new Effect(-10, new StatEffectMotivation())
                }
            ),

            new GameEvent(
                "Freelance Mission",
                "You completed a small freelance project.",
                8,
                new List<Effect>
                {
                    new Effect(50, new StatEffectMoney()),
                    new Effect(-15, new StatEffectEnergy()),
                    new Effect(1, new RandomSkillEffect())
                }
            )
        };
    }
}