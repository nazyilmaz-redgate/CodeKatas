using System.Drawing;

namespace CodeKatas.Week5;

public record MoveCommand(int MoveDistance): Command(0, MoveDistance)
{
    public override void Execute(MarsRover marsRover)
    {
        // marsRover.Position = new Point(marsRover.Position.X + marsRover.Direction.X * MoveDistance,
        //     marsRover.Position.Y + marsRover.Direction.Y * MoveDistance);
        marsRover.Position += marsRover.Direction * MoveDistance;
    }
}
