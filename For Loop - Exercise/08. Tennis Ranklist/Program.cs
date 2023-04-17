using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int pointStart = int.Parse(Console.ReadLine());

            double pointsTournamnets = 0;
            double wins = 0;
            
            for (int i = 0; i < tournaments; i++)
            {
                string position = Console.ReadLine();

                if (position == "W")
                {
                    pointsTournamnets += 2000;
                    wins += 1;
                }
                else if (position == "F")
                {
                    pointsTournamnets += 1200;
                }
                else if (position == "SF")
                {
                    pointsTournamnets += 720;
                }
            }
            double sumPoints = pointStart + pointsTournamnets;
            double averagePoints = Math.Floor(pointsTournamnets / tournaments);
            double percent = (wins / tournaments) * 100;

            Console.WriteLine($"Final points: {sumPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{percent:f2}%");
        }
    }
}
