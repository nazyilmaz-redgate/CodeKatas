using System.Drawing;


namespace CodeKatas.Week5;

public class MarsRover
{
    private readonly Point Position;
    private readonly Point Direction;
    
    
    private Point North => new(0, 1);
    private Point East => new(1, 0);
    private Point South => new(0, -1);
    private Point West => new(-1, 0);
    
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
    }
}