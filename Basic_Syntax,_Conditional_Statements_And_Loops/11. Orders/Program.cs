

namespace _11._Orders
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double price = 0;
            double totalPrice = 0;

            for (int i = 1; i <= orders; i++)
            {
                double pricePerCap = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsCount = int.Parse(Console.ReadLine());

                price = ((days * capsCount) * pricePerCap);

                Console.WriteLine($"The price for the coffee is: ${price:f2}");

                totalPrice += price;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");

        }
    }
}
