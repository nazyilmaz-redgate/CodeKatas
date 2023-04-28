using System.Drawing;
using MathNet.Numerics.LinearAlgebra;

namespace CodeKatas.Week5;

public record TurnCommand(int TurnDirection): Command(TurnDirection, 0)
{
    public override void Execute(MarsRover marsRover)
    {
        var angleOfRotationInRadians = TurnDirection * Math.PI / 2;
        // var newDirection = new Point(
        //     marsRover.Direction.X * (double)Math.Cos(angleOfRotationInRadians) - marsRover.Direction.Y * (double)Math.Sin(angleOfRotationInRadians),
        //     marsRover.Direction.X * (double)Math.Sin(angleOfRotationInRadians) + marsRover.Direction.Y * (double)Math.Cos(angleOfRotationInRadians)
        // );
        // marsRover.Direction = newDirection;
        
        var rotationMatrix = Matrix<double>.Build.DenseOfArray(new double[,]
        {
            {Math.Cos(angleOfRotationInRadians), -Math.Sin(angleOfRotationInRadians)},
            {Math.Sin(angleOfRotationInRadians), Math.Cos(angleOfRotationInRadians)}
        });
        marsRover.Direction = rotationMatrix * marsRover.Direction;
    }
}