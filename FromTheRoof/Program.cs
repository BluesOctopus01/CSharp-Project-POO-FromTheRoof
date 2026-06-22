using FromTheRoof.Class;
using FromTheRoof.Init;

class Program
{

    static void Main(string[] args)
    {
        Player player = GameInitializer.CreatePlayer();
        player.DisplayStats();
        player.DisplaySkills();

        // GameAction action = new GameAction("test",1,"testtest",)
    }
}