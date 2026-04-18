using System;

namespace FromTheRoof.Class;

public class Action
{
    private string _name;
    private int _energyCost;
    private string _description;
    private List<Effect> _effects;

    public Action(string name, int energyCost, string description,List<Effect> effects)
    {
        _name = name;
        _energyCost = energyCost;
        _description = description;
        _effects = effects;
    }
    public void Execute(Player player)
    {
        throw new NotImplementedException("Execute n'est pas encore implémenter");
    }
    public void Preview()
    {
        throw new NotImplementedException("Preview n'est pas encore implémenter");
    }
}
