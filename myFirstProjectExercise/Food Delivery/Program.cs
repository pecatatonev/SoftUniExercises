using System;

namespace Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            // •	Пилешко меню –  10.35 лв.
            // • 	Меню с риба – 12.40 лв.
            // •	Вегетарианско меню  – 8.15 лв.

            int amountOfChicken = int.Parse(Console.ReadLine());
            int amountOfFish = int.Parse(Console.ReadLine());
            int amountOfVegatarians = int.Parse(Console.ReadLine());

            double priceOfChicken = amountOfChicken * 10.35;
            double priceOfFish = amountOfFish * 12.40;
            double priceOfVegetarians = amountOfVegatarians * 8.15;

            double priceOnlyMenues = priceOfChicken + priceOfFish + priceOfVegetarians;

            double priceOfDessert = priceOnlyMenues * 0.2;

            double priceWithDessert = priceOnlyMenues + priceOfDessert;

            double priceForDelivery = priceWithDessert + 2.50;

            Console.WriteLine(priceForDelivery);

        }
    }
}
