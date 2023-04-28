using System.Drawing;
using CodeKatas.Week5;
using FluentAssertions;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;

namespace CodeKatas.Test.Week5;

public class MarsRoverTests
{
    [Test]
    public void ExecuteCommand_MoveForwardCommand_Success()
    {
        var goForwardsCommands = new List<Command> {new MoveCommand(1)};
        var initialPosition = MarsRover.BuildPosition(0, 0);
        var marsRover = new MarsRover(initialPosition, MarsRoverDirections.North, goForwardsCommands);

        marsRover.ExecuteCommands();

        var expectedEndPosition = MarsRover.BuildPosition(0, 1);
        marsRover.Should().BeEquivalentTo(new MarsRover(expectedEndPosition, MarsRoverDirections.North, new List<Command>()));
    }
    
    [TestCaseSource(nameof(TurnCases))]
    public void ExecuteCommand_TurnCommand_CorrectEndDirection(int turnDirection, Matrix<double> beginDirection, Matrix<double> endDirection)
    {
        var commands = new List<Command> {new TurnCommand(turnDirection)};
        var position = MarsRover.BuildPosition(0, 0 );
        var marsRover = new MarsRover(position, beginDirection, commands);

        marsRover.ExecuteCommands();

        marsRover.Position.Should().Be(position);
        //Avoid rounding errors
        marsRover.Direction.AlmostEqual(endDirection, 1E-6).Should().BeTrue();
    }

    public static object[] TurnCases =
    {   //Left
        new object[] { MarsRoverDirections.Left, MarsRoverDirections.North, MarsRoverDirections.West },
        new object[] { MarsRoverDirections.Left, MarsRoverDirections.West, MarsRoverDirections.South },
        new object[] { MarsRoverDirections.Left, MarsRoverDirections.South, MarsRoverDirections.East },
        new object[] { MarsRoverDirections.Left, MarsRoverDirections.East, MarsRoverDirections.North },
        //Right
        new object[] { MarsRoverDirections.Right, MarsRoverDirections.North, MarsRoverDirections.East },
        new object[] { MarsRoverDirections.Right, MarsRoverDirections.East, MarsRoverDirections.South },
        new object[] { MarsRoverDirections.Right, MarsRoverDirections.South, MarsRoverDirections.West },
        new object[] { MarsRoverDirections.Right, MarsRoverDirections.West, MarsRoverDirections.North }
    };

}