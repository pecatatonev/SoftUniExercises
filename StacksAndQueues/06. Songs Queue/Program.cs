using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Queue<string> songsInQueue = new Queue<string>();

            foreach (string s in songs)
            { 
            songsInQueue.Enqueue(s);
            }

           
            while (songsInQueue.Count > 0)
            {
                string command = Console.ReadLine();
                string[] commParams = command.Split(" ",2);

                if (commParams[0] == "Play")
                {
                    songsInQueue.Dequeue();
                }
                else if (commParams[0] == "Add")
                {
                    if (songsInQueue.Contains(commParams[1]))
                    {
                        Console.WriteLine($"{commParams[1]} is already contained!");
                    }
                    else
                    {
                        songsInQueue.Enqueue(commParams[1]);
                    }
                }
                else if (commParams[0] == "Show")
                {
                    Console.WriteLine(String.Join(", ",songsInQueue));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
