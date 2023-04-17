using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int amountFlowers = int.Parse(Console.ReadLine());
            int budjet = int.Parse(Console.ReadLine());

            double allPrice = 0;
            double discount = 0;
           

            switch (flowers)
            {
                case "Roses":
                    allPrice = amountFlowers * 5;
                    if (amountFlowers > 80)
                    {
                        discount = allPrice * 0.1;
                        allPrice = allPrice - discount;
                    }
                    break;
                case "Dahlias":
                    allPrice = amountFlowers * 3.80;
                    if (amountFlowers > 90)
                    {
                        discount = allPrice * 0.15;
                        allPrice = allPrice - discount;
                    }
                    break;
                case "Tulips":
                    allPrice = amountFlowers * 2.80;
                    if (amountFlowers > 80)
                    {
                        discount = allPrice * 0.15;
                        allPrice = allPrice - discount;
                    }
                    break;
                case "Narcissus":
                    allPrice = amountFlowers * 3.00;
                    if (amountFlowers < 120)
                    {
                        discount = allPrice * 0.15;
                        allPrice = allPrice + discount;
                    }
                    break;
                case "Gladiolus":
                    allPrice = amountFlowers * 2.50;
                    if (amountFlowers < 80)
                    {
                        discount = allPrice * 0.2;
                        allPrice = allPrice + discount;
                    }
                    break;
            }
            double difference = budjet - allPrice;

            if (budjet >= allPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {amountFlowers} {flowers} and {difference:f2} leva left.");
            }
            else if (budjet < allPrice)
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(difference):f2} leva more.");
            }
        }
    }
}
