using System;

namespace FromTheRoof.Class;

public class Skill
{
    private string _name;
    private int _level = 0;

    public string Name =>_name;
    public int Level => _level;
    public Skill(string name)
    {
        _name = name;
    }
    public void IncreaseLevel(int value)
    {
        _level += value;
    }
    public void Display()
    {
        Console.WriteLine($"{_name} - Level {_level}");
    }
}
