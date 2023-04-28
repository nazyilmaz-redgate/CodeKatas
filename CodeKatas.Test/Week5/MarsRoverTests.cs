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
    
    [TestCaseSource(nameof(TurnCases))]
    public void ExecuteCommand_TurnCommand_CorrectEndDirection(int turnDirection, Point beginDirection, Point endDirection)
    {
        var commands = new List<Command> {new TurnCommand(turnDirection)};
        var marsRover = new MarsRover(new Point(0,0), beginDirection, commands);

        marsRover.ExecuteCommands();

        marsRover.Should().BeEquivalentTo(new MarsRover(new Point(0,0), endDirection, new List<Command>()));
    }

    public static object[] TurnCases =
    {   //Left
        new object[] { 1, MarsRoverDirections.North, MarsRoverDirections.West },
        new object[] { 1, MarsRoverDirections.West, MarsRoverDirections.South },
        new object[] { 1, MarsRoverDirections.South, MarsRoverDirections.East },
        new object[] { 1, MarsRoverDirections.East, MarsRoverDirections.North },
        //Right
        new object[] { -1, MarsRoverDirections.North, MarsRoverDirections.East },
        new object[] { -1, MarsRoverDirections.East, MarsRoverDirections.South },
        new object[] { -1, MarsRoverDirections.South, MarsRoverDirections.West },
        new object[] { -1, MarsRoverDirections.West, MarsRoverDirections.North }
    };

}