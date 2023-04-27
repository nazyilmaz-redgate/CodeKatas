using System.Drawing;

namespace CodeKatas.Week5;

public record TurnCommand(int TurnDirection): Command(TurnDirection, 0)
{
    public override void Execute(MarsRover marsRover)
    {
        var angleOfRotationInRadians = TurnDirection * Math.PI / 2;
        var newDirection = new Point(
            marsRover.Direction.X * (int)Math.Cos(angleOfRotationInRadians) - marsRover.Direction.Y * (int)Math.Sin(angleOfRotationInRadians),
            marsRover.Direction.X * (int)Math.Sin(angleOfRotationInRadians) + marsRover.Direction.Y * (int)Math.Cos(angleOfRotationInRadians)
        );
        marsRover.Direction = newDirection;
    }
}