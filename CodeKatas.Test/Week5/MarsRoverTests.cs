using System.Drawing;
using CodeKatas.Week5;
using FluentAssertions;

namespace CodeKatas.Test.Week5;

public class MarsRoverTests
{
    [Test]
    public void ExecuteCommand_MoveForwardCommand_Success()
    {
        var goForwardsCommands = new List<Command> {new MoveCommand(1)};
        var marsRover = new MarsRover(new Point(0,0), MarsRoverDirections.North, goForwardsCommands);

        marsRover.ExecuteCommands();

        marsRover.Should().BeEquivalentTo(new MarsRover(new Point(0,1), MarsRoverDirections.North, new List<Command>()));
    }
    
    [Test]
    public void ExecuteCommand_TurnLeftCommand_Success()
    {
        var turnLeftCommands = new List<Command> {new TurnCommand(1)};
        var marsRover = new MarsRover(new Point(0,0), MarsRoverDirections.North, turnLeftCommands);

        marsRover.ExecuteCommands();

        marsRover.Should().BeEquivalentTo(new MarsRover(new Point(0,0), MarsRoverDirections.West, new List<Command>()));
    }
    
}