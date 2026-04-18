using System;

namespace FromTheRoof.Class;

public class Course
{
    private string _name;
    private int _minEnergyRequired;
    private string _description;
    private List<Effect> _effects;

    public Course(string name, int minEnergyRequired, string description,List<Effect> effects)
    {
        _name = name;
        _minEnergyRequired = minEnergyRequired;
        _description = description;
        _effects = effects;
    }
    public bool CanBeAttendedBy(Player player)
    {
        throw new NotImplementedException("CanBeAttendedBy n'est pas encore implémenter");
    }
    public void Attend(Player player)
    {
        throw new NotImplementedException("Attend n'est pas encore implémenter");
    }
}