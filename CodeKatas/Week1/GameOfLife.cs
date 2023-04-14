namespace CodeKatas.Week1;

public class GameOfLife
{
    private bool[][] _board;

    //private HashSet<Point> live;
    //private HashSet<Point> dead;

    public GameOfLife(bool[][] board)
    {
        _board = board;
    }

    public bool[][] NextGen()
    {
        // Rule 1
        // points.Where(x => Neighbours(x) < 2) => Dead
        return _board.Select((column, i) => column.Select((cell, j) =>
            {
                var numberOfLiveNeighbours = Neighbours(i, j);
                if (cell)
                {
                    return numberOfLiveNeighbours < 2 || numberOfLiveNeighbours > 3
                        ? false
                        : (numberOfLiveNeighbours == 2 || numberOfLiveNeighbours == 3);
                }

                return numberOfLiveNeighbours == 3;
            }).ToArray()
        ).ToArray();
    }

    private int Neighbours(int i, int j)
    {
        int neighbours = 0;

        for (int di = Math.Max(0, i - 1); di <= Math.Min(_board.Length - 1, i + 1); di++)
        {
            for (int dj = Math.Max(0, j - 1); dj <= Math.Min(_board[0].Length - 1, j + 1); dj++)
            {
                if (di == i && dj == j)
                    continue;
                else if (_board[di][dj])
                    neighbours++;
            }
        }

        return neighbours;
    }
}