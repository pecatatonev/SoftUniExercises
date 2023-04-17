using System;
using System.Linq;


namespace Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
             string input =(Console.ReadLine());

            double sumWithoutTax = 0;
            double taxes = 0;
            double sumWithTax = 0;

            while (input != "special" && input != "regular")
            {
                double prices = double.Parse(input);
                if (prices < 0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                    continue;
                }
                sumWithoutTax += prices;
                taxes = sumWithoutTax * 0.2;
                sumWithTax = sumWithoutTax + taxes;
                input = Console.ReadLine();
            }

            if (input == "special")
            {
                sumWithTax -= sumWithTax * 0.1;
            }

            if (sumWithTax == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sumWithoutTax:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {sumWithTax:f2}$");
            }
        }
    }
}
