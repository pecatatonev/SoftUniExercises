using System;
using System.Linq;

namespace _02._Space_Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] travelRoute = Console.ReadLine()
                .Split("||").
                ToArray();

            int fuelStart = int.Parse(Console.ReadLine());
            int ammunitionStart = int.Parse(Console.ReadLine());

            string command = string.Empty;
            int numberParam = 0;
            for (int i = 0; i < travelRoute.Length; i++)
            {
                string[] inputParams = travelRoute[i].Split();
                command = inputParams[0];
                if (command != "Titan")
                {
                    numberParam = int.Parse(inputParams[1]);
                }

                if (command == "Travel")
                {
                    if (numberParam <= fuelStart)
                    {
                        Console.WriteLine($"The spaceship travelled {numberParam} light-years.");
                        fuelStart -= numberParam;
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }
                }
                else if (command == "Enemy")
                {
                    if (ammunitionStart >= numberParam)
                    {
                        Console.WriteLine($"An enemy with {numberParam} armour is defeated.");
                        ammunitionStart -= numberParam;
                    }
                    else if (ammunitionStart < numberParam)
                    {
                        fuelStart -= numberParam * 2;
                        if (fuelStart >= 0 )
                        {
                            Console.WriteLine($"An enemy with {numberParam} armour is outmaneuvered.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }
                    }

                }
                else if (command == "Repair")
                {
                    fuelStart += numberParam;
                    ammunitionStart += numberParam * 2;
                    Console.WriteLine($"Ammunitions added: {numberParam*2}.");
                    Console.WriteLine($"Fuel added: {numberParam}.");
                }
                else if (command == "Titan")
                {
                    Console.WriteLine($"You have reached Titan, all passengers are safe.");
                    return;
                }
            }
        }
    }
}
