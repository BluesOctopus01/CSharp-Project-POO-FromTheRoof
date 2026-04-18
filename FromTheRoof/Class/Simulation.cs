using System;

namespace FromTheRoof.Class;

public class Simulation
{
    private Player _player;
    private Day _currentDay;
    private Year _currentYear;
    private bool _isRunning = true;

    public Simulation(Player player , Day day, Year currentYear, bool isRunning)
    {
        _player = player;
        _currentDay = day;
        _currentYear = currentYear;
        _isRunning = isRunning;
        
    }
    public void Start()
    {
        throw new NotImplementedException("Start n'est pas encore implémenter");
    }
    public void PlayCurrentDay()
    {
        throw new NotImplementedException("PlayCurrentDay n'est pas encore implémenter");
    }
    public void GoToNextDay()
    {
        throw new NotImplementedException("GoToNextDay n'est pas encore implémenter");
    }
}