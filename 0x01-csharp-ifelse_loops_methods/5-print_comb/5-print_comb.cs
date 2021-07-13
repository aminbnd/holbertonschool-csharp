using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                string number = i.ToString("d2");
                if (i < 99)
                    Console.Write($"{number}, ");
                else
                    Console.Write(number);
            }
        }
    }
}
