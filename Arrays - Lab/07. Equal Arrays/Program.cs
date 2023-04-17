using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersOne = Console.ReadLine()
              .Split(' ')
              .Select(int.Parse)
              .ToArray();

            int[] numbersTwo = Console.ReadLine()
              .Split(' ')
              .Select(int.Parse)
              .ToArray();

            int sum = 0;

            for (int i = 0; i < numbersOne.Length; i++)
            {
                int currNum1 = numbersOne[i];
                
                    int currNum2 = numbersTwo[i];
                    if (currNum1 != currNum2)
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        return;
                    }
                    else
                    {
                        sum += currNum2;
                    }
                
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
