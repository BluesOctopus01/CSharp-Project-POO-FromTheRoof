using System;
using FromTheRoof.Class;

namespace FromTheRoof.Init;

public static class GameInitializer
{
    public static Player CreatePlayer()
    {
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
        return new List<Skill>{
        new Skill("C#", "Programmation orientée objet en C#"),
        new Skill("SQL", "Gestion de bases de données"),
        new Skill("Web", "Développement d'applications web"),
        new Skill("Réseaux", "Bases des réseaux informatiques"),
        new Skill("Cybersécurité", "Sécurisation des systèmes et services")
    };
    }

}
