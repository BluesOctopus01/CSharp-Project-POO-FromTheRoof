using System;

namespace FromTheRoof.Ui;

public static class GameUi
{
public static void ShowTitle()
    {
         Console.WriteLine(@"
         ______                     _   _                             __ 
        |  ____|                   | | | |                           / _|
        | |__ _ __ ___  _ __ ___   | |_| |__   ___   _ __ ___   ___ | |_ 
        |  __| '__/ _ \| '_ ` _ \  | __| '_ \ / _ \ | '__/ _ \ / _ \|  _|
        | |  | | | (_) | | | | | | | |_| | | |  __/ | | | (_) | (_) | |  
        |_|  |_|  \___/|_| |_| |_|  \__|_| |_|\___| |_|  \___/ \___/|_|  
                                                                        
                                                                        ");
    }
public static void ShowHeader(int dayNumber,string playerName)
    {
        Console.WriteLine("========================================");
        Console.WriteLine($"DAY {dayNumber}/7 - {playerName}");
        Console.WriteLine("========================================");
        Console.WriteLine();
    }

    public static void Pause(string message = "Press any key to continue...")
    {
        Console.WriteLine();
        Console.WriteLine(message);
        Console.ReadKey(true);
    }

    public static void Loading(string message="Loading")
    {
        Console.Write(message);

        for (int i = 0; i < 5; i++)
        {
            Thread.Sleep(300);
            Console.Write(".");
        }

        Console.WriteLine();
    }
    public static void Clear()
    {
        Console.Clear();
    }
}
