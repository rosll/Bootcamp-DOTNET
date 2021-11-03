using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLimit = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= numLimit; i++)
            {
                string[] calc = Console.ReadLine().Split(" ");
                double x = double.Parse(calc[0]);
                double y = double.Parse(calc[1]);

                if (y == 0)
                {
                    Console.WriteLine("Divisão impossível");
                }
                else
                {
                    double result = x / y;
                    Console.WriteLine(result.ToString("F1"));
                }
            }
        }
    }
}