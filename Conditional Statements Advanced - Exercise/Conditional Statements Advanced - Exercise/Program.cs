using System;

namespace Conditional_Statements_Advanced___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double price = 0;

            if (projection == "Premiere")
            {
                price = r * c * 12;
            }
            else if (projection == "Normal")
            {
                price = r * c * 7.50;
            }
            else if (projection == "Discount")
            {
                price = r * c * 5;
            }

            Console.WriteLine($"{price:f2} leva");
        }
    }
}
