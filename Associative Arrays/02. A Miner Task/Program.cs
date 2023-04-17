using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources 
                = new Dictionary<string, int>();

            string input = Console.ReadLine();

            int oddOrEven = 1;
            string resource = string.Empty;
            while (input != "stop")
            {
                if (resources.ContainsKey(input))
                {
                    resource = input;
                    oddOrEven--;
                    input = Console.ReadLine();
                    continue;
                }
                if (oddOrEven % 2 != 0)
                {
                    resources.Add(input, 0);
                    resource = input;
                }
                if (oddOrEven % 2 == 0)
                {
                    int quantity = int.Parse(input);
                    resources[resource] += quantity;
                }

                oddOrEven++;
                input = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

    }
}
