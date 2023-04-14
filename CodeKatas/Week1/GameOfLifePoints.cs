

using System.Drawing;

namespace CodeKatas.Week1;

public class GameOfLifePoints
{
    private HashSet<Point> _live;
    private HashSet<Point> _dead;

    private HashSet<Point> _points;
    
    public GameOfLifePoints(bool[][] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j])
                {
                    _live.Add(new Point(i, j));
                }
                else
                {
                    _dead.Add(new Point(i, j));
                }
            }
        }

        _points = _live.Concat(_dead).ToHashSet();
    }

    // public bool[][] NextGeneration()
    // {
    //     // Rule 1
    //     // Any live cell with fewer than two live neighbours dies, as if caused by under-population.
    //     var newDead = _live.Where(x => NumberOfLiveNeighbours(x) < 2);
    //     // Rule 2
    //     // Any live cell with two or three live neighbours lives on to the next generation.
    //     var newLive = _live.Where(x => NumberOfLiveNeighbours(x) == 2 || NumberOfLiveNeighbours(x) == 3);
    // }

    // private int NumberOfLiveNeighbours(Point point)
    // {
    //     
    // }

}