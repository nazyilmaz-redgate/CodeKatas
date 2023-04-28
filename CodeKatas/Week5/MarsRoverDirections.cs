using System.Drawing;
using MathNet.Numerics.LinearAlgebra;

namespace CodeKatas.Week5;

public static class MarsRoverDirections
{
    public static Matrix<double> North => Matrix<double>.Build.DenseOfArray(new double[,] {  {0},  {1} });
    public static Matrix<double> East => Matrix<double>.Build.DenseOfArray(new double[,]  {  {1},  {0} });
    public static Matrix<double> South => Matrix<double>.Build.DenseOfArray(new double[,] {  {0}, {-1} });
    public static Matrix<double> West => Matrix<double>.Build.DenseOfArray(new double[,]  { {-1},  {0} });

    public const int Left = 1;
    public const int Right = -1;
}