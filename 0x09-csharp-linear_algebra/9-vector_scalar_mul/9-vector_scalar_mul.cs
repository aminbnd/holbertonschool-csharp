using System;

/// <summary>
/// VectorMath Class
/// </summary>
class VectorMath
{
    /// <summary>
    /// Scales a vector
    /// </summary>
    /// <param name="vector"></param>
    /// <param name="scalar"></param>
    /// <returns></returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length < 2 || vector.Length < 3)
            return new double[] { -1 };

        double[] newVector = new double[3];
        for (int i = 0; i < vector.Length; i++)
        {
            newVector[i] = vector[i] * scalar;
        }
        return newVector;
    }
}