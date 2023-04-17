using System;

namespace _03._Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            double price = 0;
            switch (place)
            {
                case "Bulgaria":
                    price = dancers * points;
                    switch (season)
                    {
                        case "summer":
                            price -= price * 0.05; 
                            break;
                        case "winter":
                            price -= price * 0.08;
                            break;
                    }
                    break;
                case "Abroad":
                    price = dancers * points;
                    price += price / 2;
                    switch (season)
                    {
                        case "summer":
                            price -= price * 0.1;
                            break;
                        case "winter":
                            price -= price * 0.15;
                            break;
                    }
                    break;
            }

            double priceForCharity =price * 0.75;
            double priceForDancers = price - priceForCharity;

            Console.WriteLine($"Charity - {priceForCharity:f2}");
            Console.WriteLine($"Money per dancer - {priceForDancers / dancers:f2}");
        }
    }
}
