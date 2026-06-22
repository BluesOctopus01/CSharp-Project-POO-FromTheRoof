using System;

namespace FromTheRoof.Class;

public class Player
{
    private string _name;
    private StatSheet _stat;
    private List<Skill> _skills;

    public Player(string name, StatSheet stat, List<Skill> skills)
    {
        _name = name;
        _stat = stat;
        _skills = skills;
    }
    public StatSheet Stats => _stat;
    public void DisplayStats()
    {
        _stat.DisplayStat();
    }
    public void DisplaySkills()
    {
        Console.WriteLine("=== Skills ===");
        foreach(Skill skill in _skills)
        {
            skill.Display();
        }
    }
    public bool CanAttendCourse(Course course)
    {
        throw new NotImplementedException("CanAttendCourse n'est pas encore implémenter");
    }
    public bool GetSkillByName(string name)
    {
        throw new NotImplementedException("GetSkillByName n'est pas encore implémenter");
    }
}
