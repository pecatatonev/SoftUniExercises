using System;

namespace _04._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceKilosVegetables = double.Parse(Console.ReadLine());
            double priceKilosFruits = double.Parse(Console.ReadLine());
            int kilosVegetables = int.Parse(Console.ReadLine());
            int kilosFruits = int.Parse(Console.ReadLine());

            double priceVegetablesInLv = priceKilosVegetables * kilosVegetables;
            double priceFruitsInLv = priceKilosFruits * kilosFruits;
            double sumInLv = priceVegetablesInLv + priceFruitsInLv;
            double sumInEuro = sumInLv / 1.94;

            Console.WriteLine($"{sumInEuro:f2}");
        }
    }
}
