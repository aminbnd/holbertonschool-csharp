using System;
/// <summary>
/// VectorMath: Class
/// </summary>
public class VectorMath
{
    /// <summary>
    /// calculates the sum of two vectors
    /// </summary>
    /// <param name="vector1">First vector</param>
    /// <param name="vector2">Second vector</param>
    /// <returns></returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        int lenVector1 = vector1.Length;
        int lenVector2 = vector2.Length;

        if (lenVector1 != lenVector2 || lenVector1 != 2 && lenVector1 != 3 || lenVector2 != 2 && lenVector2 != 3)
            return new double[]{ -1 };


        double[] sum = new double[lenVector1];

        for (int i = 0; i < lenVector1; i++)
        {
            sum[i] = vector1[i] + vector2[i];
        }
        Console.WriteLine(sum);
        return sum;
    }
}