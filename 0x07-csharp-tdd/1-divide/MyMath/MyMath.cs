using System;

namespace MyMath
{
    /// <summary>
    /// Maths
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divides Numbers in a matrix
        /// </summary>
        /// <param name="matrix">Matrix to be divided</param>
        /// <param name="num">Divider</param>
        /// <returns>New matrix filled with divided numbers</returns>
        public static int[,] Divide(int [,] matrix, int num)
        {
            if(matrix == null)
                return null;
            int [,] newMatrix = new int[matrix.GetLength(0),matrix.GetLength(1)];
            for(int i = 0; i <matrix.GetLength(0); i++)
            {
                for(int j = 1; j<matrix.GetLength(1); j++)
                {
                    try
                    {
                        newMatrix[i,j] = matrix[i,j]/num;
                    }
                    catch
                    {
                        Console.WriteLine("Num cannot be 0");
                        return null;
                    }
                }
            }
            return newMatrix;
        }
    }
}
