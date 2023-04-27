using gol;

namespace CodeKatas.Week5;

public abstract record Command
{
    private readonly int TurnDirection;
    private readonly int MoveDistance;

    protected Command(int turnDirection, int moveDistance)
    {
        TurnDirection = turnDirection;
        MoveDistance = moveDistance;
    }

    public abstract void Execute(MarsRover marsRover);
}