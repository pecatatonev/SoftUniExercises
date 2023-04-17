using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());
            double priceForGreen = squareMeters * 7.61;
            double discount = 0.18 * priceForGreen;
            double finalPrice = priceForGreen - discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        } 
    }
}

