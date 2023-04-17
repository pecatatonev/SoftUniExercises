using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForTrip = double.Parse(Console.ReadLine());

            int amountPuzzles = int.Parse(Console.ReadLine());
            int amountDolls = int.Parse(Console.ReadLine());
            int amountBears = int.Parse(Console.ReadLine());
            int amountMinions = int.Parse(Console.ReadLine());
            int amountTrucks = int.Parse(Console.ReadLine());

            int amountOfToys = amountPuzzles + amountDolls + amountBears + amountMinions + amountTrucks;

            //Пъзел - 2.60 лв.
            //Говореща кукла -3 лв.
            //Плюшено мече -4.10 лв.
            //Миньон - 8.20 лв.
            //Камионче - 2 лв.
            double pricePuzzles = amountPuzzles * 2.60;
            double priceDolls = amountDolls * 3;
            double priceBears = amountBears * 4.10;
            double priceMinions = amountMinions * 8.20;
            double priceTrucks = amountTrucks * 2;

            double totalPrice = pricePuzzles + priceDolls + priceBears + priceMinions + priceTrucks;
            
            if (amountOfToys >=50)
            {
                totalPrice = totalPrice - totalPrice * 0.25;
            }

            totalPrice = totalPrice - totalPrice * 0.10;

            double difference = totalPrice - priceForTrip;
            if (difference>=0)
            {
                Console.WriteLine($"Yes! {difference:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(difference):f2} lv needed.");
            }
        }
    }
}
