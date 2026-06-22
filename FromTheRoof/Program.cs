using FromTheRoof.Class;
using FromTheRoof.Init;

class Program
{

    static void Main(string[] args)
    {
        Player player = GameInitializer.CreatePlayer();
        player.DisplayStats();
        player.DisplaySkills();

        List<GameAction> actions = ActionInitilizer.CreateDefaultActions();
        foreach(GameAction act in actions)
        {
            act.Preview();
        }
    }
}