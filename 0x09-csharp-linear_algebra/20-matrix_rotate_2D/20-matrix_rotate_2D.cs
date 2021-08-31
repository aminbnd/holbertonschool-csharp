using System;
using System.Linq;

/// <summary>
/// MatrixMath: Class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Get a given row fromp a matrix
    /// </summary>
    /// <param name="mat">matrix of double</param>
    /// <param name="rowRank">Rank of the chosen row</param>
    /// <returns>array</returns>
    public static double[] RowsNumber(double[,] mat, int rowRank)
    {
        return Enumerable.Range(0, mat.GetLength(0))
                .Select(x => mat[rowRank, x])
                .ToArray();
    }

    /// <summary>
    /// Rotates a square 2D matrix
    /// </summary>
    /// <param name="matrix">the matrix</param>
    /// <param name="angle">Rotation angle</param>
    /// <returns>the new matrix</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2) return new double[,] { { -1 } };

        double[,] newMat = new double[2, 2];
        
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            double[] row = MatrixMath.RowsNumber(matrix, i);

            newMat[i, 0] = Math.Round(Math.Round(row[0] * Math.Cos(angle), 2) - Math.Round(row[1] * Math.Sin(angle), 2), 2);
            newMat[i, 1] = Math.Round(Math.Round(row[0] * Math.Sin(angle), 2) + Math.Round(row[1] * Math.Cos(angle), 2), 2);
        }
        return newMat;
    }
}