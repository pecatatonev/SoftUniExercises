using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            //	Видеокарта – 250 лв./бр.
            // Процесор – 35 % от цената на закупените видеокарти/ бр.
            //Рам памет – 10 % от цената на закупените видеокарти/ бр.

            double budgetPeter = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int procesors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            
            double priceVideoCards = videoCards * 250;
            double priceProcesors = procesors * (priceVideoCards * 0.35);
            double priceRam = ram * (priceVideoCards * 0.10);

            double allPrice = priceVideoCards + priceProcesors + priceRam;
            double discount = 0;

            if (videoCards > procesors)
            {
                discount = allPrice * 0.15;
            }

            double newPrice = allPrice - discount;

            double difference = budgetPeter - newPrice;

            if (budgetPeter >= newPrice)
            {
                Console.WriteLine($"You have {difference:f2} leva left!");
            }
            else if (budgetPeter < newPrice)
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(difference):f2} leva more!");
            }
        }
    }
}
