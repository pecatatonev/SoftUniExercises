using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
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

            while (input != "End")
            {
                string[] inputParams = input.Split();
                string command = inputParams[0];

                if (command == "Add")
                {
                    int number = int.Parse(inputParams[1]);

                    numbers.Add(number);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(inputParams[1]);
                    int index = int.Parse(inputParams[2]);

                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        input = Console.ReadLine();
                        continue;
                    }

                    numbers.Insert(index , number);
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(inputParams[1]);
                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        input = Console.ReadLine();
                        continue;
                    }

                    numbers.RemoveAt(index);
                }
                else if (command == "Shift")
                {
                    string command2 = inputParams[1];
                    int count = int.Parse(inputParams[2]);
                    if (command2 == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                       
                    }
                    else if (command2 == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                        
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
