using System;

namespace FromTheRoof.Class;

public class Skill
{
    private string _name;
    private int _level = 0;
    private string _description;

    public Skill(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void IncreaseLevel(int value)
    {
        throw new NotImplementedException("IncreaseLevel n'est pas encore implémenter");
    }
    public void Display()
    {
        throw new NotImplementedException("Display n'est pas encore implémenter");
    }
}
