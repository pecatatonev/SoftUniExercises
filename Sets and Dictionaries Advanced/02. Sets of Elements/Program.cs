using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = num[0];
            int m = num[1];

            HashSet<int> numbers1 = new HashSet<int>(); 
            HashSet<int> numbers2 = new HashSet<int>(); 

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                numbers1.Add(input);
            }
            for (int i = 0; i < m; i++)
            {
                int input = int.Parse(Console.ReadLine());
                numbers2.Add(input);
            }

            var intersect = numbers1.Intersect(numbers2);

            foreach (var item in intersect)
            {
                Console.Write(item + " ");
            }
        }
    }
}
