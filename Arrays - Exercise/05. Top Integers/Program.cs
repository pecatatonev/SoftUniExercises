using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int currN = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                currN = numbers[i];

                bool isTopInteger = true;
                for (int j =i + 1; j < numbers.Length; j++)
                {
                    
                    if (numbers[j] >= currN)
                    {
                        isTopInteger = false;
                        break;
                    }
                    
                }
                if (isTopInteger)
                {
                    Console.Write(currN + " ");
                }
                
            }
        }
    }
}
