using System;

namespace FromTheRoof.Class;

public class Simulation
{
    private Player _player;
    private List<GameAction> _actions;
    private List<Course> _courses;
    private List<GameEvent> _events;
    private Day _currentDay;
    private int _currentDayNumber = 1;
    private bool _isRunning = true;
    public Simulation(Player player, List<GameAction> actions, List<Course> courses, List<GameEvent> events)
    {
        _player = player;
        _actions = actions;
        _courses = courses;
        _events = events;
        _currentDay = new Day(_currentDayNumber);
    }

    public void Start()
    {
        Console.ReadKey(true);
        
        while (_isRunning && _currentDayNumber <= 7)
        {
            PlayCurrentDay();
            GoToNextDay();
        }

        Console.WriteLine("Week finished !");
    }

    public void PlayCurrentDay()
    {
        Console.WriteLine($"=== DAY {_currentDayNumber} {_player.Name} ===");

        _player.DisplayStats();
        _player.DisplaySkills();

        PlanActionForCurrentDay();

        Console.WriteLine();
        Console.WriteLine("=== Running day ===");
        AssignRandomEventToCurrentDay();
        _currentDay.Run(_player);

        Console.WriteLine();
        Console.WriteLine("=== End of day ===");
        _player.DisplayStats();
        _player.DisplaySkills();

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
    }

    private void GoToNextDay()
    {
        _currentDayNumber++;
        _currentDay = new Day(_currentDayNumber);
    }

    private void PlanActionForCurrentDay()
    {
        bool isPlanning = true;

        while (isPlanning)
        {
            Console.WriteLine();
            Console.WriteLine("=== Planning ===");
            Console.WriteLine("1. Add action");
            Console.WriteLine("2. Remove action");
            Console.WriteLine("3. Show planned day");
            Console.WriteLine("4. Start day");
            Console.Write("Choice : ");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    AddActionToCurrentDay();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey(true);
                    break;

                case "2":
                    RemoveActionFromCurrentDay();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey(true);
                    break;

                case "3":
                    _currentDay.DisplaySummary();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey(true);
                    break;

                case "4":
                    isPlanning = false;
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey(true);
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey(true);
                    break;
            }
        }
    }

    private void AddActionToCurrentDay()
    {
        Console.WriteLine();
        Console.WriteLine("=== Available actions ===");

        for (int i = 0; i < _actions.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _actions[i].Preview();
        }

        Console.Write("Choose action number : ");
        string input = Console.ReadLine() ?? "";

        if (int.TryParse(input, out int choice))
        {
            int index = choice - 1;

            if (index >= 0 && index < _actions.Count)
            {
                _currentDay.AddAction(_actions[index]);
            }
            else
            {
                Console.WriteLine("Invalid action number...");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }

    private void RemoveActionFromCurrentDay()
    {
        _currentDay.DisplaySummary();

        Console.Write("Choose planned action number to remove : ");
        string input = Console.ReadLine() ?? "";

        if (int.TryParse(input, out int choice))
        {
            _currentDay.RemoveAction(choice - 1);
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    private void AssignRandomEventToCurrentDay()
    {
        foreach (GameEvent gameEvent in _events)
        {
            if (gameEvent.CanOccur())
            {
                _currentDay.SetEvent(gameEvent);
                return;
            }
        }
    }
}