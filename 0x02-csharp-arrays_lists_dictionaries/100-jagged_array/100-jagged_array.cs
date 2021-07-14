using System;
using System.Text;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagg =
            {
                new int [] { 0, 1, 2, 3 },
                new int [] { 0, 1, 2, 3, 4, 5, 6 },
                new int [] { 0, 1 }
            };
            //Console.WriteLine(jagg);
            StringBuilder tiAyEsm = new StringBuilder();
            for (int i = 0; i < jagg.Length; i++)
            {
                tiAyEsm.Clear();
                for (int j = 0; j < jagg[i].Length; j++)
                {
                    tiAyEsm.Append(jagg[i][j]);
                    if (jagg[i].Length - 1 != j)
                        tiAyEsm.Append(" ");
                }
                Console.WriteLine(tiAyEsm);
            }
        }
    }
}
