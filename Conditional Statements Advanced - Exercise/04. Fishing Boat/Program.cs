using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budjet = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int amountOfPeople = int.Parse(Console.ReadLine());

            int priceForRent = 0;
            double discount = 0;
            double priceWithDiscount = 0;

                switch (season)
            {
                case "Spring":
                    priceForRent = 3000;
                    break;
                case "Winter":
                    priceForRent = 2600;
                    break;
                case "Summer":
                case "Autumn":
                    priceForRent = 4200;
                    break;
            }
            if (amountOfPeople <= 6)
            {
                discount = priceForRent * 0.1;
                priceWithDiscount = priceForRent - discount;
            }
            else if (amountOfPeople >= 7 && amountOfPeople <= 11)
            {
                discount = priceForRent * 0.15;
                priceWithDiscount = priceForRent - discount;
            }
            else
            {
                discount = priceForRent * 0.25;
                priceWithDiscount = priceForRent - discount;
            }

            if (amountOfPeople % 2 == 0 && season != "Autumn")
            {
                discount = priceWithDiscount * 0.05;
                priceWithDiscount = priceWithDiscount - discount;
            }

            double difference = budjet - priceWithDiscount;

            if (budjet >= priceWithDiscount)
            {
                Console.WriteLine($"Yes! You have {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(difference):f2} leva.");
            }
        }
    }
}
