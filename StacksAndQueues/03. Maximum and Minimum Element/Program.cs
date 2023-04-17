using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] num = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (num[0] == 1)
                {
                    numbers.Push(num[1]);
                }
                else if (num[0] == 2)
                {
                    if (numbers.Count <= 0)
                    {
                        continue;
                    }
                    numbers.Pop();
                }
                else if (num[0] == 3)
                {
                    if (numbers.Count <= 0)
                    {
                        continue;
                    }
                    int biggestNum = int.MinValue;
                    foreach (var chislo in numbers)
                    {
                        if (biggestNum < chislo)
                        {
                            biggestNum = chislo;
                        }
                    }
                    Console.WriteLine(biggestNum);
                }
                else if (num[0] == 4)
                {
                    if (numbers.Count <= 0)
                    {
                        continue;
                    }
                    int smallestNum = int.MaxValue;
                    foreach (var chislo in numbers)
                    {
                        if (smallestNum > chislo)
                        {
                            smallestNum = chislo;
                        }
                    }
                    Console.WriteLine(smallestNum);
                }
            }

            Console.WriteLine(String.Join(", ",numbers));
        }
    }
}
