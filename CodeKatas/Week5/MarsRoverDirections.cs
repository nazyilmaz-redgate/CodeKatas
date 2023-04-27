using System.Drawing;

namespace CodeKatas.Week5;

public static class MarsRoverDirections
{
    public static Point North => new(0, 1);
    public static Point East => new(1, 0);
    public static Point South => new(0, -1);
    public static Point West => new(-1, 0);
}