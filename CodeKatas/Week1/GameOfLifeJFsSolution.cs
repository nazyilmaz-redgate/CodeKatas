namespace gol;

public record struct Point(int X, int Y): IEquatable<Point> {

    public IEnumerable<Point> Neighbours() {
        yield return new Point(X - 1, Y );
        yield return new Point(X - 1, Y + 1);
        yield return new Point(X - 1, Y - 1);       
        
        yield return new Point(X + 1, Y );
        yield return new Point(X + 1, Y + 1 );
        yield return new Point(X + 1, Y - 1);

        yield return new Point(X, Y + 1);
        yield return new Point(X, Y - 1);
    }

    public static IEnumerable<Point> Grid(int x, int y) {
        for (int i=0;i<x;++i)
            for (int j=0;j<y;++j) {
                yield return new Point(i,j);
            }
    }
}

public class GameOfLife {

    private HashSet<Point> liveCells = new ();

    public HashSet<Point> LiveCells { get { return liveCells; } }

    private int _width;

    private int _height;

    public GameOfLife(int w, int h, IEnumerable<Point> liveCells) {
        _width = w;
        _height = h;
        this.liveCells = new HashSet<Point>(liveCells);
    }

    public GameOfLife Evolve() {
        var newCells = Point.Grid(_width, _height).Where(x => !liveCells.Contains(x) && x.Neighbours().Count(liveCells.Contains) == 3);

        var livesOn = liveCells.Where(x => {
            var n = x.Neighbours().Count(liveCells.Contains);
            return n == 2 || n == 3;
        });

        return new GameOfLife(_width, _height, livesOn.Union(newCells));
        
    }
}
