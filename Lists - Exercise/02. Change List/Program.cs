using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
           .Split(" ")
           .Select(int.Parse)
           .ToList();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputParams = input.Split();
                string command = inputParams[0];
                if (command == "Delete")
                {
                    int element = int.Parse(inputParams[1]);
                    numbers.RemoveAll(x => x == element);
                }
                else if (command == "Insert")
                {
                    int element = int.Parse(inputParams[1]);
                    int position = int.Parse(inputParams[2]);
                    numbers.Insert(position, element);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
