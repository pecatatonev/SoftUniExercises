using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int timeEpisode = int.Parse(Console.ReadLine());
            int timeBreak = int.Parse(Console.ReadLine());

            double timeForSeries = timeBreak * 5.0 / 8;

            if (timeForSeries >= timeEpisode)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(timeForSeries - timeEpisode)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(timeEpisode - timeForSeries)} more minutes.");
            }
        }
    }
}
