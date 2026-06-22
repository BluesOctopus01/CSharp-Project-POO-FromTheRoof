using System;

namespace FromTheRoof.Class;

public class Day
{
    private int _number;
    private List<GameAction> _plannedActions;
    private int _maxActionPoint = 5;
    private int _usedActionPoint =0 ;

    public Day(int number = 1)
    {
        _number = number;
        _plannedActions = new List<GameAction>();
        
    }
    public bool AddAction(GameAction action)
    {
        if (_usedActionPoint + action.ActionPointCost > _maxActionPoint)
        {
            Console.WriteLine("Not enough action points");
            return false;
        }
        _plannedActions.Add(action);
        _usedActionPoint +=action.ActionPointCost;

        Console.WriteLine($"{action.Name} added.");
        return true;
    }
    public bool RemoveAction(int index)
    {
    if (index < 0 || index >= _plannedActions.Count)
    {
        Console.WriteLine("Invalid action index");
        return false;
    }

    GameAction action = _plannedActions[index];

    _plannedActions.RemoveAt(index);
    _usedActionPoint -= action.ActionPointCost;

    Console.WriteLine($"{action.Name} removed");
        return true;
    }   
    public void Run(Player player)
    {
        foreach(GameAction action in _plannedActions)
        {
            action.Execute(player);
        }
    }
    public void DisplaySummary()
    {
    Console.WriteLine($"Day {_number}");
    Console.WriteLine($"Action Points : {_usedActionPoint}/{_maxActionPoint}");

    for (int i = 0; i < _plannedActions.Count; i++)
    {
        Console.Write($"{i + 1}. ");
        _plannedActions[i].Preview();
    }
}
    
}