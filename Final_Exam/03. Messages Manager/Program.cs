using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Messages_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Finish it later

            int capacity = int.Parse(Console.ReadLine());

            Dictionary<string, int> sentMessages = new Dictionary<string, int>();
            Dictionary<string, int> recievedMessages = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "Statistics") 
            {
                string[] inputParams = input.Split("=");

                string command = inputParams[0];
                if (command == "Add")
                {
                    string username = inputParams[1];

                    if (!sentMessages.ContainsKey(username))
                    {
                        int sent = int.Parse(inputParams[2]);
                        int recieved = int.Parse(inputParams[3]);
                        sentMessages.Add(username, sent);
                        recievedMessages.Add(username, recieved);
                    } 
                }
                else if (command == "Message")
                {
                    string sender = inputParams[1];
                    string receiver = inputParams[2];
                    

                    if (sentMessages.ContainsKey(sender) && recievedMessages.ContainsKey(receiver))
                    {
                        sentMessages[sender] += 1;
                        recievedMessages[receiver] += 1;
                    }
                    if (sentMessages[sender] + recievedMessages[sender] >= capacity)
                    {
                        sentMessages.Remove(sender);
                        recievedMessages.Remove(sender);
                        Console.WriteLine($"{sender} reached the capacity!");
                    }
                    if (recievedMessages[receiver] + sentMessages[receiver] >= capacity)
                    {
                        sentMessages.Remove(receiver);
                        recievedMessages.Remove(receiver);
                        Console.WriteLine($"{receiver} reached the capacity!");
                    }
                }
                else if (command == "Empty")
                {
                    string username = inputParams[1];

                    if (sentMessages.ContainsKey(username))
                    {
                        sentMessages.Remove(username);
                        recievedMessages.Remove(username);

                    }
                    if (username == "All")
                    {
                        sentMessages.Clear();
                        recievedMessages.Clear();
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Users count: {sentMessages.Count}");
            foreach (var (person,messages) in recievedMessages)
            {
                Console.WriteLine($"{person} - {messages+ sentMessages[person]}");
            }
        }
    }
}
