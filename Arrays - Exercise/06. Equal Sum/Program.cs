using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sumright = 0;
            int sumleft = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    sumright += numbers[j];
                }
                for (int k = 0; k < i; k++)
                {
                    sumleft += numbers[k];
                }

                if (sumright==sumleft)
                {
                    Console.WriteLine(i);
                    return;
                }
                sumright = 0;
                sumleft = 0;
            }

            Console.WriteLine("no");
        }
    }
}
