
namespace CodeKatas.Week5;

public abstract record Command(int TurnDirection, int MoveDistance)
{
    public abstract void Execute(MarsRover marsRover);
}