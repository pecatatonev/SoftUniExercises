using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try nested Dictionary

            int capacity = int.Parse(Console.ReadLine());

            SortedDictionary<string, List<int>> Messages = new SortedDictionary<string, List<int>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] inputParams = input.Split("=", StringSplitOptions.RemoveEmptyEntries);

                string command = inputParams[0];
                if (command == "Add")
                {
                    string username = inputParams[1];

                    if (!Messages.ContainsKey(username))
                    {
                        int sent = int.Parse(inputParams[2]);
                        int recieved = int.Parse(inputParams[3]);
                        Messages.Add(username, new List<int>());
                        Messages[username].Add(sent);
                        Messages[username].Add(recieved);
                    }
                }
                else if (command == "Message")
                {
                    string sender = inputParams[1];
                    string receiver = inputParams[2];


                    if (Messages.ContainsKey(sender) && Messages.ContainsKey(receiver))
                    {
                        Messages[sender][0] += 1;
                        Messages[receiver][1] += 1;

                        if (Messages[sender].Sum() >= capacity)
                        {
                            Messages.Remove(sender);
                            Console.WriteLine($"{sender} reached the capacity!");
                        }
                        if (Messages[receiver].Sum() >= capacity)
                        {
                            Messages.Remove(receiver);
                            Console.WriteLine($"{receiver} reached the capacity!");
                        }
                    }
                }
                else if (command == "Empty")
                {
                    string username = inputParams[1];

                    if (Messages.ContainsKey(username))
                    {
                        Messages.Remove(username);
                        
                    }
                    if (username == "All")
                    {
                        Messages.Clear();
                    }
                }
            }
            Console.WriteLine($"Users count: {Messages.Count}");
            foreach (var person in Messages)
            {
                int sum = person.Value.Sum();
                Console.WriteLine($"{person.Key} - {sum}");
            }

        }
    }
}
