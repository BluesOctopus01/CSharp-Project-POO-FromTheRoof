using System;
using FromTheRoof.Interface;

namespace FromTheRoof.Class;

public class StatSheet
{
    private int _energy = 100;
    private int _motivation = 100;
    private int _stress = 0;
    private double _money = 25.0;
    private List<IStatObserver> _observers = new();
    public void AddObserver(IStatObserver observer)
    {
        _observers.Add(observer);
    }
    private void NotifyObserver()
    {
        foreach(IStatObserver observer in _observers)
        {
            observer.OnStatChanged(this);
        }
    }

    public bool IsExhausted => _energy <= 0;
    public bool IsBurnedOut => _stress >= 100;
    public bool IsBroke => _money <= 0;

    public bool IsMotivated => _motivation >= 50;
    public int Energy => _energy;
    public void ModifyEnergy(int value)
    {
        _energy += value;
        _energy = Math.Clamp(_energy, 0, 100);
        NotifyObserver();
        
    }
    public void ModifyMotivation(int value)
    {
        _motivation += value;
        _motivation = Math.Clamp(_motivation, 0, 100);
        NotifyObserver();
    }
    public void ModifyStress(int value)
    {
        _stress += value;
        _stress = Math.Clamp(_stress, 0, 100);
        NotifyObserver();
    }
    public void ModifyMoney(double value)
    {
        _money += value;
        _money = Math.Clamp(_money, 0, 9999);
        NotifyObserver();
    }
    public void DisplayStat()
    {
        Console.WriteLine("--- Stats ---");
        Console.WriteLine($"Energy : {_energy}");
        Console.WriteLine($"Motivation : {_motivation}");
        Console.WriteLine($"Stress : {_stress}");
        Console.WriteLine($"Money : {_money}€");
    }
}