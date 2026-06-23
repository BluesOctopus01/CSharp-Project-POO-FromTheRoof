using FromTheRoof.Class;

namespace FromTheRoof.Interface;

public interface IStatObserver
{
    void OnStatChanged(StatSheet stats);
}
