using System;
using FromTheRoof.Effects;
namespace FromTheRoof.Class;

public class GameAction
{
    private string _name;
    private int _actionPointCost;
    private List<Effect> _effects;

    public GameAction(string name, int actionPoint,List<Effect> effects)
    {
        _name = name;
        _actionPointCost = actionPoint;
        _effects = effects;
    }
    public void Execute(Player player)
    {
        foreach(Effect effect in _effects)
        {
            effect.Apply(player);
        }
    }
    public void Preview()
    {
        Console.WriteLine($"{_name} : - {_actionPointCost} Action Point");
    }
}
