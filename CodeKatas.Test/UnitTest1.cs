using CodeKatas.Week1;

namespace CodeKatas.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void OneByOneBoard_DeadCells_DeadAfterwards()
    {
        bool[][] board =  {
            new [] {false}
        };

        var gameOfLife = new GameOfLife(board);
        var boardSecondGen = gameOfLife.NextGen();
        
        Assert.That(boardSecondGen, Is.EquivalentTo(board));
    }
    
    [Test]
    public void FiveByThreeBoard_Success()
    {
        bool[][] board =  {
            new [] {false, false, false},
            new [] {false, true, false},
            new [] {true, false, false},
            new [] {true, false, false},
            new [] {false, false, false}
        };
        
        bool[][] expectedBoard =  {
            new [] {false, false, false},
            new [] {false, false, false},
            new [] {true, true, false},
            new [] {false, false, false},
            new [] {false, false, false}
        };

        var gameOfLife = new GameOfLife(board);
        var boardSecondGen = gameOfLife.NextGen();
        
        Assert.That(boardSecondGen, Is.EquivalentTo(expectedBoard));
    }
}