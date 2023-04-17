using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Queue<int> stack = new Queue<int>();
            int numbersPush = numbers[0];
            int numbersPop = numbers[1];
            int elementLookFor = numbers[2];

            int[] numbersForTheStack = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbersPush; i++)
            {
                stack.Enqueue(numbersForTheStack[i]);
            }
            for (int i = 0; i < numbersPop; i++)
            {
                stack.Dequeue();
            }

            if (stack.Count <= 0)
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
