using System;
using FromTheRoof.Class;

namespace FromTheRoof.Init;

public static class GameInitializer
{
    public static Player CreatePlayer()
    {
    Console.WriteLine(@"
         ______                     _   _                             __ 
        |  ____|                   | | | |                           / _|
        | |__ _ __ ___  _ __ ___   | |_| |__   ___   _ __ ___   ___ | |_ 
        |  __| '__/ _ \| '_ ` _ \  | __| '_ \ / _ \ | '__/ _ \ / _ \|  _|
        | |  | | | (_) | | | | | | | |_| | | |  __/ | | | (_) | (_) | |  
        |_|  |_|  \___/|_| |_| |_|  \__|_| |_|\___| |_|  \___/ \___/|_|  
                                                                        
                                                                        ");
        string name = AskPlayerName();
        return new Player(name,new StatSheet(),CreateDefaultSkills());
    }
    private static string AskPlayerName()
    {
        string name = "";
        while (string.IsNullOrWhiteSpace(name))
        {
            Console.Write("Enter Player Name : ");
            name = Console.ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty");
            }
        }
        return name;
    }
    private static List<Skill> CreateDefaultSkills()
    {
        return new List<Skill>
        {
            new Skill("C#"),
            new Skill("SQL"),
            new Skill("Web"),
            new Skill("Network"),
            new Skill("Cybersecurity")
        };
    }
    
}
