using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();

            List<int> secondHand = Console.ReadLine()
                       .Split()
                       .Select(int.Parse)
                       .ToList();

            int firstHandIndex = 0;
            int secondHandIndex = 0;
            while (firstHand.Count > 0 && secondHand.Count > 0)
            {
                
                if (firstHand[firstHandIndex] > secondHand[secondHandIndex])
                {
                    firstHand.Add(secondHand[secondHandIndex]);
                    firstHand.Add(firstHand[firstHandIndex]);
                    firstHand.Remove(firstHand[firstHandIndex]);
                    secondHand.Remove(secondHand[secondHandIndex]);
                }
                else if (firstHand[firstHandIndex] < secondHand[secondHandIndex])
                {
                    secondHand.Add(firstHand[firstHandIndex]);
                    secondHand.Add(secondHand[secondHandIndex]);
                    firstHand.Remove(firstHand[firstHandIndex]);
                    secondHand.Remove(secondHand[secondHandIndex]);
                }
                else if (firstHand[firstHandIndex] == secondHand[secondHandIndex])
                {
                    firstHand.Remove(firstHand[firstHandIndex]);
                    secondHand.Remove(secondHand[secondHandIndex]);
                }
               
            }

            if (firstHand.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
            }
            else if (secondHand.Count == 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
            }
            
        }
    }
}
