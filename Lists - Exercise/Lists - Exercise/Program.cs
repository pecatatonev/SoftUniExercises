using System;
using System.Collections.Generic;
using System.Linq;


namespace Lists___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> passengersInWagons = Console.ReadLine()
           .Split(" ")
           .Select(int.Parse)
           .ToList();

            int maxCapOfWagon = int.Parse(Console.ReadLine());
            int value = 0;
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputParams = input.Split();
                string command = inputParams[0];
                if (command == "Add")
                {
                    value = int.Parse(inputParams[1]);
                    passengersInWagons.Add(value);
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    value = int.Parse(command);
                    
                }

                for (int i = 0; i < passengersInWagons.Count; i++)
                {
                    if (passengersInWagons[i] + value <= maxCapOfWagon)
                    {
                        passengersInWagons[i] += value;
                        break;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",passengersInWagons));
        }
    }
}
