using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Queue<int> orderQueue = new Queue<int>();

            for (int i = 0; i < orders.Length; i++)
            {
                orderQueue.Enqueue(orders[i]);
            }

            int biggestOrder = int.MinValue;
            while (orderQueue.Count != 0)
            {
                int poruchka = orderQueue.Peek();
                if (biggestOrder < poruchka)
                {
                    biggestOrder = poruchka;
                }
                if (quantityOfFood < poruchka)
                {
                    Console.WriteLine(biggestOrder);
                    Console.WriteLine($"Orders left: {String.Join(" ", orderQueue)}");

                    return;
                }
                orderQueue.Dequeue();
                quantityOfFood -= poruchka;
            }
            Console.WriteLine(biggestOrder);
            Console.WriteLine("Orders complete");
        }
    }
}
