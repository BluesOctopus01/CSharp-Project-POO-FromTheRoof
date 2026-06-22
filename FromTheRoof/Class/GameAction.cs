using System;

namespace FromTheRoof.Class;

public class GameAction
{
    private string _name;
    private int _energyCost;
    private List<Effect> _effects;

    public GameAction(string name, int energyCost, string description,List<Effect> effects)
    {
        _name = name;
        _energyCost = energyCost;
        _effects = effects;
    }
    public void Execute(Player player)
    {
        throw new NotImplementedException("Execute n'est pas encore implémenter");
    }
    public void Preview()
    {
        Console.WriteLine($"{_name} : - {_energyCost} PA");
    }
}
