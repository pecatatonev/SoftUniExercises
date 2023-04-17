using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int amountNights = int.Parse(Console.ReadLine());

            double priceAps = 0;
            double priceStudio = 0;
            double discountStudio = 0;
            double discountAps = 0;


            switch (month)
            {
                case "May":
                case "October":
                    priceAps = amountNights * 65;
                    
                    priceStudio = amountNights * 50;
                    if (amountNights > 14)
                    {
                        discountStudio = 0.3;
                    }
                    else if (amountNights > 7)
                    {
                        discountStudio =  0.05;
                    }   
                    break;

                case "June":
                case "September":
                    priceAps = amountNights * 68.70;

                    priceStudio = amountNights * 75.20;
                        if (amountNights > 14)
                    {
                        discountStudio = 0.2;
                    }
                    break;
                case "July":
                case "August":
                    priceAps = amountNights * 77;

                    priceStudio = amountNights * 76;
                    break;

                    

                    
            }

            if (amountNights > 14)
            {
                discountAps  = 0.1;
            }
            Console.WriteLine($"Apartment: {priceAps - priceAps * discountAps:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio - priceStudio * discountStudio:f2} lv.");
        } 
    }
}


