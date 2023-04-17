using System;

namespace _05._Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double wInCm = (w * 100);
            double hInCm = (h * 100 - 100);
            double wDesks = wInCm / 120;
            double hDesks = hInCm / 70;
            double wCheck = Math.Truncate(wDesks);
            double hCheck = Math.Truncate(hDesks);
            double numberOfSeats = wCheck * hCheck - 3;

            Console.WriteLine($"{numberOfSeats}");
        }
    }
}
