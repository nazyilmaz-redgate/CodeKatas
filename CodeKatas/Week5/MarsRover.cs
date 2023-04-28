using System.Drawing;
using MathNet.Numerics.LinearAlgebra;


namespace CodeKatas.Week5;

public class MarsRover
{
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
        foreach (var command in Commands)
        {
            command.Execute(this);
        }
        Commands.Clear();
    }
}