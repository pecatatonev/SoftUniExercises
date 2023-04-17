using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            int index1 = 0;
            int index2 = 0;
            int moves = 0;
            while (input != "end")
            {
                string[] inputParams = input.Split();
                index1 = int.Parse(inputParams[0]);
                index2 = int.Parse(inputParams[1]);
                moves++;
                if (index1 == index2 || index1 > elements.Count || index2 > elements.Count || index1 < 0 || index2 < 0)
                {
                    elements.Insert(elements.Count / 2, $"-{moves}a");
                    elements.Insert(elements.Count / 2, $"-{moves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    input = Console.ReadLine();
                    continue;
                }
                if (elements[index1] == elements[index2])
                {

                    Console.WriteLine($"Congrats! You have found matching elements - {elements[index1]}!");
                    if (index1 > index2 )
                    {
                        elements.RemoveAt(index1);
                        elements.RemoveAt(index2);
                    }
                    else
                    {
                        elements.RemoveAt(index2);
                        elements.RemoveAt(index1);
                    }
                    
                    
                }
                else if (elements[index1] != elements[index2])
                {
                    Console.WriteLine("Try again!");
                    

                }
                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    break;
                }

                input = Console.ReadLine();
            }

            if (elements.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }
           
        }
    }
}
