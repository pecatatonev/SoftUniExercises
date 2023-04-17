using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();
            int numbersPush = numbers[0];
            int numbersPop = numbers[1];
            int elementLookFor = numbers[2];

            int[] numbersForTheStack = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbersPush; i++)
            {
                stack.Push(numbersForTheStack[i]);
            }
            for (int i = 0; i < numbersPop; i++)
            {
                stack.Pop();
            }

            if (stack.Count <= 0 )
            {
                Console.WriteLine(0);
                return;
            }
            int smallestNum = int.MaxValue;
            foreach (var num in stack)
            {
                if (smallestNum > num)
                {
                    smallestNum = num;
                }
            }
            foreach (var num in stack)
            {
                if (num == elementLookFor)
                {
                    Console.WriteLine("true");
                    return;
                }
            }
                Console.WriteLine(smallestNum);
        }
    }
}
