namespace FromTheRoof.Class;

public class GameEvent
{
    private string _name;
    private string _description;
    private int _probability;
    private List<Effect> _effects;

    private static Random _random = new Random();

    public string Name => _name;
    public string Description => _description;

    public GameEvent(string name, string description, int probability, List<Effect> effects)
    {
        _name = name;
        _description = description;
        _probability = probability;
        _effects = effects;
    }

    public void Trigger(Player player)
    {
        Console.WriteLine();
        Console.WriteLine($"EVENT : {_name}");
        Console.WriteLine(_description);

        foreach (Effect effect in _effects)
        {
            effect.Apply(player);
        }
    }

    public bool CanOccur()
    {
        int roll = _random.Next(1, 101);

        return roll <= _probability;
    }
}