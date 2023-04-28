using System.Drawing;
using MathNet.Numerics.LinearAlgebra;

namespace CodeKatas.Week5;

public static class MarsRoverDirections
{
    public static Matrix<double> North => BuildDirection(0, 1);
    public static Matrix<double> East => BuildDirection(1, 0);
    public static Matrix<double> South => BuildDirection(0, -1);
    public static Matrix<double> West => BuildDirection(-1, 0);

    public const int Left = 1;
    public const int Right = -1;
    
    private static Matrix<double> BuildDirection(int x, int y)
    {
        return Matrix<double>.Build.DenseOfArray(new double[,] { {x}, {y} });
    }
}