using System.Drawing;


namespace CodeKatas.Week5;

public class MarsRover
{
    public Point Position;
    public Point Direction;
    
    private readonly List<Command> Commands;

    public MarsRover(Point position, Point direction, List<Command> commands)
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