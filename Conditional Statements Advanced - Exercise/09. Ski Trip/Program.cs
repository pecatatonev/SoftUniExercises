using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string grade = Console.ReadLine();

            double allPrice = 0;

            days = days - 1;

            switch (room)
            {
                case "room for one person":
                    allPrice = days * 18;
                    break;
                case "apartment":
                    allPrice = days * 25;
                    if (days < 10)
                    {
                        allPrice = allPrice - allPrice * 0.3;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        allPrice = allPrice - allPrice * 0.35;
                    }
                    else
                    {
                        allPrice = allPrice - allPrice * 0.5;
                    }
                    break;
                case "president apartment":
                    allPrice = days * 35;
                    if (days < 10)
                    {
                        allPrice = allPrice - allPrice * 0.1;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        allPrice = allPrice - allPrice * 0.15;
                    }
                    else
                    {
                        allPrice = allPrice - allPrice * 0.2;
                    }
                    break;
            }

            if (grade =="positive")
            {
                allPrice = allPrice + allPrice * 0.25;
            }
            else if (grade == "negative")
            {
                allPrice = allPrice - allPrice * 0.1;
            }

            Console.WriteLine($"{allPrice:f2}");
        }
    }
}
