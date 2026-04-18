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
    public void DisplayStats()
    {
        throw new NotImplementedException("DisplayStats n'est pas encore implémenter");
    }
    public void DisplaySkills()
    {
        throw new NotImplementedException("DisplaySkills n'est pas encore implémenter");
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
