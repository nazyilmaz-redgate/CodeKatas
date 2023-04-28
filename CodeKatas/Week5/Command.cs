using gol;
using MathNet.Numerics.LinearAlgebra;

namespace CodeKatas.Week5;

public abstract record Command
{
    private readonly int TurnDirection;
    private readonly int MoveDistance;

    // protected Matrix<double> TranslationMatrix;
    
    protected Command(int turnDirection, int moveDistance)
    {
        TurnDirection = turnDirection;
        MoveDistance = moveDistance;
        // TranslationMatrix = Matrix<double>.Build.DenseOfArray(new double[,]
        // {
        //     {MoveDistance},
        //     {MoveDistance}
        // });
    }

    public abstract void Execute(MarsRover marsRover);
}