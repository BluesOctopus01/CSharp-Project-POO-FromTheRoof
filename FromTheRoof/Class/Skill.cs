using System;

namespace FromTheRoof.Class;

public class Skill
{
    private string _name;
    private int _level = 0;

    public Skill(string name)
    {
        _name = name;
    }
    public void IncreaseLevel(int value)
    {
        throw new NotImplementedException("IncreaseLevel n'est pas encore implémenter");
    }
    public void Display()
    {
        Console.WriteLine($"{_name} - Level {_level}");
    }
}
