using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            switch (day)
            {
                case "Friday":
                    switch (type)
                    {
                        case "Students":
                            price = 8.45;
                            break;
                        case "Business":
                            price = 10.90;
                            break;
                        case "Regular":
                            price = 15;
                            break;
                    }
                    break;
                case "Saturday":
                    switch (type)
                    {
                        case "Students":
                            price = 9.80;
                            break;
                        case "Business":
                            price = 15.60;
                            break;
                        case "Regular":
                            price = 20;
                            break;
                    }
                    break;
                case "Sunday":
                    switch (type)
                    {
                        case "Students":
                            price = 10.46;
                            break;
                        case "Business":
                            price = 16;
                            break;
                        case "Regular":
                            price = 22.50;
                            break;
                    }
                    break;
            }

            double totalPrice = people * price;

            if (type == "Students" && people >= 30)
            {
                totalPrice = totalPrice * 0.85;
            }
            else if (type == "Business" && people >= 100)
            {
                totalPrice = totalPrice - (price * 10);
            }
            else if (type == "Regular" && people >= 10 && people <=20)
            {
                totalPrice = totalPrice * 0.95;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
