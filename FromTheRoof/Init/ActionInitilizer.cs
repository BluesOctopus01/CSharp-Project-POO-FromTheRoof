using System;
using FromTheRoof.Class;
using FromTheRoof.Effects;

namespace FromTheRoof.Init;

public static class ActionInitilizer
{
    public static List<GameAction> CreateDefaultActions()
    {
        return new List<GameAction>
        {
            new GameAction(
                "Take a Random Book and study",
            1,
            new List<Effect>
            {
                new Effect(1,new RandomSkillEffect()),
                new Effect(10, new StatEffectStress()),
                new Effect(-5,new StatEffectMotivation())
            }),
            new GameAction(
                "Study For Exam",
                2,
                new List<Effect>
                {
                    new Effect(1, new RandomSkillEffect()),
                    new Effect(15, new StatEffectStress()),
                    new Effect(-10, new StatEffectMotivation())
                }
            ),

            new GameAction(
                "Sleep",
                1,
                new List<Effect>
                {
                    new Effect(40, new StatEffectEnergy()),
                    new Effect(-20, new StatEffectStress()),
                    new Effect(5, new StatEffectMotivation())
                }
            ),

            new GameAction(
                "Work",
                3,
                new List<Effect>
                {
                    new Effect(50, new StatEffectMoney()),
                    new Effect(-25, new StatEffectEnergy()),
                    new Effect(10, new StatEffectStress()),
                    new Effect(-5, new StatEffectMotivation())
                }
            ),

            new GameAction(
                "Play Video Games",
                2,
                new List<Effect>
                {
                    new Effect(20, new StatEffectMotivation()),
                    new Effect(-10, new StatEffectEnergy()),
                    new Effect(-5, new StatEffectStress())
                }
            ),

            new GameAction(
                "Go Out With Friends",
                2,
                new List<Effect>
                {
                    new Effect(15, new StatEffectMotivation()),
                    new Effect(-10, new StatEffectMoney()),
                    new Effect(-10, new StatEffectStress())
                }
            ),

            new GameAction(
                "Drink Coffee",
                1,
                new List<Effect>
                {
                    new Effect(15, new StatEffectEnergy()),
                    new Effect(5, new StatEffectStress()),
                    new Effect(-5, new StatEffectMoney())
                }
            )
        };
    }
}