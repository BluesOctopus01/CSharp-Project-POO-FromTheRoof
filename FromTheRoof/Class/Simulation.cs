using System;
using System.Threading;
using FromTheRoof.Ui;
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
    {   GameUi.ShowTitle();
        GameUi.Pause("Press any key to start...");

        while (_isRunning && _currentDayNumber <= 7)
        {
            PlayCurrentDay();
            GoToNextDay();
        }

        GameUi.Clear();
        Console.WriteLine("=== WEEK FINISHED ===");
        GameUi.Pause();
    }

    public void PlayCurrentDay()
    {
        Console.Clear();
        GameUi.ShowHeader(_currentDayNumber, _player.Name);

        _player.DisplayStats();
        Console.WriteLine();
        _player.DisplaySkills();

        GameUi.Pause();

        PlanActionForCurrentDay();

        Console.Clear();
        GameUi.ShowHeader(_currentDayNumber, _player.Name);

        Console.WriteLine("Running day...");
        GameUi.Loading();

        AssignRandomEventToCurrentDay();
        _currentDay.Run(_player);

        Console.WriteLine();
        Console.WriteLine("=== END OF DAY ===");
        Console.WriteLine();

        _player.DisplayStats();
        Console.WriteLine();
        _player.DisplaySkills();

        GameUi.Pause();
    }

    private void PlanActionForCurrentDay()
    {
        bool isPlanning = true;

        while (isPlanning)
        {
            Console.Clear();
            GameUi.ShowHeader(_currentDayNumber, _player.Name);

            Console.WriteLine("=== PLANNING ===");
            Console.WriteLine("1. Add action");
            Console.WriteLine("2. Remove action");
            Console.WriteLine("3. Show planned day");
            Console.WriteLine("4. Start day");
            Console.WriteLine();
            Console.Write("Choice : ");

            string choice = Console.ReadLine() ?? "";

            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    AddActionToCurrentDay();
                    break;

                case "2":
                    RemoveActionFromCurrentDay();
                    break;

                case "3":
                    _currentDay.DisplaySummary();
                    GameUi.Pause();
                    break;

                case "4":
                    isPlanning = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    GameUi.Pause();
                    break;
            }
        }
    }

    private void AddActionToCurrentDay()
    {
        Console.Clear();
        GameUi.ShowHeader(_currentDayNumber, _player.Name);

        Console.WriteLine("=== AVAILABLE ACTIONS ===");
        Console.WriteLine();

        for (int i = 0; i < _actions.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _actions[i].Preview();
        }

        Console.WriteLine();
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
                Console.WriteLine("Invalid action number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }

        GameUi.Pause();
    }

    private void RemoveActionFromCurrentDay()
    {
        Console.Clear();
        GameUi.ShowHeader(_currentDayNumber, _player.Name);

        Console.WriteLine("=== REMOVE ACTION ===");
        Console.WriteLine();

        _currentDay.DisplaySummary();

        Console.WriteLine();
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

        GameUi.Pause();
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

    private void GoToNextDay()
    {
        _currentDayNumber++;
        _currentDay = new Day(_currentDayNumber);
    }

}