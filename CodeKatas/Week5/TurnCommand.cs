namespace CodeKatas.Week5;

public record TurnCommand(int TurnDirection): Command(TurnDirection, 0)
{
    public override void Execute(MarsRover marsRover)
    {
        throw new NotImplementedException();
    }
}