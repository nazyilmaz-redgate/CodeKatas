using System.Drawing;
using MathNet.Numerics.LinearAlgebra;


namespace CodeKatas.Week5;

public class MarsRover
{
    public static Matrix<double> BuildPosition(int x, int y)
    {
        return Matrix<double>.Build.DenseOfArray(new double[,] { {x}, {y} });
    }

    public Matrix<double> Position;
    public Matrix<double> Direction;
    
    private readonly List<Command> Commands;

    public MarsRover(Matrix<double> position, Matrix<double> direction, List<Command> commands)
    {
        Position = position;
        Direction = direction;
        Commands = commands;
    }

    public void ExecuteCommands()
    {
        Commands.ForEach(c => c.Execute(this));
        Commands.Clear();
    }
}