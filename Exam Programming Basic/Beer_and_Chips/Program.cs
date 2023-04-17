using System;

namespace Beer_and_Chips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int numbeer = int.Parse(Console.ReadLine());
            int numchips = int.Parse(Console.ReadLine());

            double pricebeer = numbeer * 1.20;
            double priceonechips = pricebeer * 0.45;
            double pricechips = Math.Ceiling(numchips * priceonechips);
            

            double sum = pricebeer + pricechips;

            double diff = budget - sum;
                if (budget >= sum)
            {
                Console.WriteLine($"{name} bought a snack and has {diff:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {sum - budget:f2} more leva!");
            }

        }
    }
}
