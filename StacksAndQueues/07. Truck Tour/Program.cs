using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfPumps = int.Parse(Console.ReadLine());

            Queue<long[]> pumps = new();
            List<long[]> pumpsOrg = new();

            for (int i = 0; i < numbersOfPumps; i++)
            {
                long[] infoForPumps = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();

               pumps.Enqueue(infoForPumps);
               pumpsOrg.Add(infoForPumps);
            }

            int startingStation = 0;
            long truckTank = 0;
            int counter = 0;

            for (int i = 0; i < numbersOfPumps; i++)
            {
                long[] tmp = pumps.Dequeue();
                long petrolAmount = tmp[0];
                long nextStationKM = tmp[1];

                truckTank += petrolAmount;

                if (truckTank>= nextStationKM)
                {
                    truckTank -= nextStationKM;
                }
                else
                {
                    truckTank = 0;
                    startingStation = ++counter;
                    i = 0;
                    if (startingStation <= numbersOfPumps-1)
                    {
                        pumps.Clear();
                        foreach (var p in pumpsOrg)
                        {
                            pumps.Enqueue(p);
                        }

                        for (int j = 0; j < startingStation; j++)
                        {
                            long[] tmp1 = pumps.Dequeue();
                            pumps.Enqueue(tmp1);
                        }
                    }
                    else
                    {
                        startingStation = -1;
                        break;
                    }
                }

            }
            Console.WriteLine(startingStation);
        }
    }
}
