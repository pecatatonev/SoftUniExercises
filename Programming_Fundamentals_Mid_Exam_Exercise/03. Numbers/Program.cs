using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            double avg = integers.Average();
            List<int> orderList = new List<int>();

            
            orderList.AddRange(integers.Where(x => x > (int)avg));
            orderList.Sort();
            orderList.Reverse();
            if (orderList.Count <= 0)
            {
                Console.WriteLine("No");
                return;
            }

            for (int i = orderList.Count-1; i >= 5; i--)
            {
                orderList.RemoveAt(i);
            }
            Console.WriteLine(string.Join(" ", orderList));


        }
    }
}
