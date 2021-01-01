using System;

namespace LabWorkOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Таблица умножения:");
            int firstMulitiplier, secondMultiplier;
            for (firstMulitiplier = 2; firstMulitiplier <= 9; firstMulitiplier++)
            {
                for (secondMultiplier = 2; secondMultiplier <= 9; secondMultiplier++)
                    Console.WriteLine(firstMulitiplier + " * " + secondMultiplier + " = "+(firstMulitiplier*secondMultiplier));
            }
        }
    }
}
