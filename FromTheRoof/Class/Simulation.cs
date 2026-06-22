using System;

namespace FromTheRoof.Class;

public class Simulation
{
    private Player _player;
    private List<GameAction> _actions;
    private List<Course>_courses;
    private Day _currentDay;
    private int _currentDayNumber = 1;
    private bool _isRunning = true;

    public Simulation(Player player ,List<GameAction> actions, List<Course> courses)
    {
        _player = player;
        _actions = actions;
        _courses = courses;
        _currentDay = new Day(_currentDayNumber);
        
    }
    public void Start()
    {
        while (_isRunning && _currentDayNumber <= 7)
        {
            PlayCurrentDay();

            GoToNextDay();
        }

        Console.WriteLine("Week finished !");
    }
    public void PlayCurrentDay()
    {
        Console.Clear();

        Console.WriteLine($"=== DAY {_currentDayNumber} ===");

        _player.DisplayStats();
        _player.DisplaySkills();

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
    }
    public void GoToNextDay()
    {
        _currentDayNumber ++;
        _currentDay = new Day(_currentDayNumber);
    }
}