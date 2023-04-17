using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputParams = input.Split();
                string name = inputParams[0];

                if (input == $"{name} is going!")
                {
                    if (i == 0)
                    {
                        guests.Add(name);
                        continue;
                    }

                    if (guests.Any(x => x == name))
                    {
                        Console.WriteLine($"{name} is already in the list!");

                    }
                    else
                    {
                        guests.Add(name);

                    }

                }
                else if (input == $"{name} is not going!")
                {


                    if (guests.Any(x => x == name))
                    {
                        guests.Remove(name);

                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }

                }

            }
            Console.WriteLine(string.Join(Environment.NewLine, guests));

        }
    }
}
