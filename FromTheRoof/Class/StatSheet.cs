using System;

namespace FromTheRoof.Class;

public class StatSheet
{
    private int _energy = 100;
    private int _motivation = 50;
    private int _stress = 0;
    private double _money = 25.0;

    public StatSheet(int energy , int motivation, int stress, double money)
    {
        _energy = energy;
        _motivation = motivation;
        _stress = stress;
        _money = money;
    }
    public void ModifyEnergy()
    {
        throw new NotImplementedException("ModifyEnergy n'est pas encore implémenter");
    }
    public void ModifyMotivation()
    {
        throw new NotImplementedException("ModifyMotivation n'est pas encore implémenter");
    }
    public bool ModifyStress()
    {
        throw new NotImplementedException("ModifyStress n'est pas encore implémenter");
    }
    public bool ModifyMoney()
    {
        throw new NotImplementedException("ModifyMoney n'est pas encore implémenter");
    }
}