using System;

namespace FromTheRoof.Class;

public class Course
{
    private string _name;
    private int _minEnergyRequired;
    private List<Effect> _effects;

    public Course(string name, int minEnergyRequired,List<Effect> effects)
    {
        _name = name;
        _minEnergyRequired = minEnergyRequired;
        _effects = effects;
    }
    public bool CanBeAttendedBy(Player player)
    {
        return player.Stats.Energy >= _minEnergyRequired;
    }
    public void Attend(Player player)
    {
        foreach(Effect effects in _effects)
        {
            effects.Apply(player);
        }
    }
}