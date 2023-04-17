using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> usernameAndPlates = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] paramsPlates = input.Split();
                string regOrNot = paramsPlates[0];
                

                if (regOrNot == "register")
                {
                    string username = paramsPlates[1];
                    string plate = paramsPlates[2];
                    if (usernameAndPlates.ContainsKey(username))
                    {

                        Console.WriteLine($"ERROR: already registered with plate number {plate}");

                    }
                    else
                    {
                        usernameAndPlates.Add(username, plate);
                        Console.WriteLine($"{username} registered {plate} successfully");
                    }
                }
                else if (regOrNot == "unregister")
                {
                    string username = paramsPlates[1];
                    if (!usernameAndPlates.ContainsKey(username))
                    {

                        Console.WriteLine($"ERROR: user {username} not found");

                    }
                    else
                    {
                        usernameAndPlates.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");  
                    }
                }
            }

            foreach (var item in usernameAndPlates)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

        }
    }
}
