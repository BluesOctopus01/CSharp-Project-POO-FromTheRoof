using System;

namespace FromTheRoof.Class;

public class Day
{
    private int _number = 1;
    private List<Action> _plannedActions;
    private Event? _dailyEvent;
    private Course? _dailyCourse;

    public Day(int number = 1)
    {
        _number = number;
        _plannedActions = new List<Action>();
        _dailyEvent = null;
        _dailyCourse = null;
        
    }
    public void AddAction(Action action)
    {
        throw new NotImplementedException("AddAction n'est pas encore implémenter");
    }
    public void Run(Player player)
    {
        throw new NotImplementedException("Run n'est pas encore implémenter");
    }
    public void DisplaySummary()
    {
        throw new NotImplementedException("DisplaySummary n'est pas encore implémenter");
    }
}