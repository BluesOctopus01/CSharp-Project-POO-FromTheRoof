using System;

namespace FromTheRoof.Class;

public class Exam
{
    private string _name;
    private string _requiredSkillName;
    private int _requiredLevel;
    private bool _isPassed = false;

    public Exam(string name, string requiredSkillName, int requiredLevel)
    {
        _name = name;
        _requiredSkillName = requiredSkillName;
        _requiredLevel = requiredLevel;
    }
    public bool CanBePassed(Player player)
    {
        throw new NotImplementedException("CanBePassed n'est pas encore implémenter");
    }
    public void Pass(Player player)
    {
        throw new NotImplementedException("Pass n'est pas encore implémenter");
    }
}