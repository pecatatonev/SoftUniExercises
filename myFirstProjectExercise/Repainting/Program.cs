using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            //	Предпазен найлон -1.50 лв.за кв. метър
            //	Боя - 14.50 лв.за литър
            //	Разредител за боя - 5.00 лв.за литър


            int amountOfNaylon = int.Parse(Console.ReadLine());
            int amountOfPaint = int.Parse(Console.ReadLine());
            int amountOfThinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double priceOfNaylon = (amountOfNaylon + 2) * 1.50;
            double priceOfPaint = (amountOfPaint + amountOfPaint * 0.1) * 14.50;
            double priceOfThinner = amountOfThinner * 5.00;
            double priceForBags = 0.40;

            double sumForMaterials = priceOfNaylon + priceOfPaint + priceOfThinner + priceForBags;

            double sumForWorkers = (sumForMaterials * 0.3) * hours;

            double sumForAllThings = sumForMaterials + sumForWorkers;

            Console.WriteLine(sumForAllThings);
            
        }
    }
}
