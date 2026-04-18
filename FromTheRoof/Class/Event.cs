using System;

namespace FromTheRoof.Class;

public class Event
{
    private string _name;
    private string _description;
    private int _probability;
    private List<Effect> _effects;

    public Event(string name, string description, int probability,List<Effect> effects)
    {
        _name = name;
        _description = description;
        _probability = probability;
        _effects = effects;
    }
    public void Trigger(Player player)
    {
        throw new NotImplementedException("Trigger n'est pas encore implémenter");
    }
    public bool CanOccur()
    {
        throw new NotImplementedException("CanOccur n'est pas encore implémenter");
    }
}