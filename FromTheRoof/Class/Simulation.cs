using FromTheRoof.Interface;
using FromTheRoof.Ui;
namespace FromTheRoof.Class;

public class Simulation : IStatObserver
{
    private Player _player;
    private List<GameAction> _actions;
    private List<Course> _courses;
    private List<GameEvent> _events;
    private Exam _finalExam = new Exam("Final Exam");
    private Day _currentDay;
    private int _currentDayNumber = 1;
    private bool _isRunning = true;
    private bool _forceFinalExam = false;
    private string _criticalEndingMessage = "";

    public Simulation(Player player, List<GameAction> actions, List<Course> courses, List<GameEvent> events)
    {
        _player = player;
        _actions = actions;
        _courses = courses;
        _events = events;
        _currentDay = new Day(_currentDayNumber);
        _player.Stats.AddObserver(this);
    }

    public void Start()
    {   GameUi.ShowTitle();
        GameUi.Pause("Press any key to start...");

        while (_isRunning && _currentDayNumber < 7)
        {
            PlayCurrentDay();
            GoToNextDay();
        }

        PlayFinalExam();
    }

    public void PlayCurrentDay()
    {
        AssignCourseToCurrentDay();
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
        if (HandleCriticalEnding())
        {
            return;
        }
        AttendDailyCourse();
        if (HandleCriticalEnding())
        {
            return;
        }
        GameUi.ShowSection("END OF DAY");

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
            GameUi.ShowSection("PLANNING");
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
        GameUi.ShowSection("AVAILABLE ACTIONS");

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
        GameUi.ShowSection("REMOVE ACTION");

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
    private void AssignCourseToCurrentDay()
    {
        if (_currentDayNumber == 7)
        {
            return;
        }
        int courseIndex = (_currentDayNumber - 1)%_courses.Count;
        _currentDay.SetCourse(_courses[courseIndex]);
    }
    private void AttendDailyCourse()
    {
        if (_currentDay.DailyCourse == null)
        {
            return;
        }

        GameUi.ShowSection("DAILY COURSE");

        Console.WriteLine($"Today's course : {_currentDay.DailyCourse.Name}");
        Console.WriteLine();

        Console.WriteLine("1. Attend the course");
        Console.WriteLine("2. Skip the course");
        Console.WriteLine();

        Console.Write("Choice : ");

        string input = Console.ReadLine() ?? "";

        Console.WriteLine();

        if (input == "1")
        {
            _currentDay.DailyCourse.Attend(_player);
        }
        else
        {
            GameUi.ShowMessage("You skipped the course.");
        }

        GameUi.Pause();
    }
    private void GoToNextDay()
    {
        _currentDayNumber++;
        _currentDay = new Day(_currentDayNumber);
    }
    private void PlayFinalExam()
    {
        GameUi.Clear();

        GameUi.ShowSection("FINAL EXAM");

        GameUi.Loading("Calculating final score");

        Console.WriteLine();

        _finalExam.DisplayResult(_player);

        GameUi.Pause();
    }
    public void OnStatChanged(StatSheet stats)
    {
        if (_forceFinalExam)
            return;

        if (stats.IsExhausted)
        {
            _criticalEndingMessage = "You collapse from exhaustion. Days pass while you recover. The final exam arrives before you are ready.";
            _forceFinalExam = true;
            return;
        }

        if (stats.IsBurnedOut)
        {
            _criticalEndingMessage = "Stress takes over completely. You burn out and lose several days. The final exam is already here.";
            _forceFinalExam = true;
            return;
        }

        if (stats.IsBroke)
        {
            _criticalEndingMessage = "You run out of money. Survival becomes your priority, and studying falls apart. The final exam arrives too soon.";
            _forceFinalExam = true;
        }
    }
    private bool HandleCriticalEnding()
    {
        if (!_forceFinalExam)
            return false;

        GameUi.Clear();

        GameUi.ShowSection("TIME SKIP");

        GameUi.ShowMessage(_criticalEndingMessage);

        Console.WriteLine();
        GameUi.ShowMessage("You are now facing the final exam.");

        GameUi.Pause();

        _currentDayNumber = 7;

        return true;
    }
}