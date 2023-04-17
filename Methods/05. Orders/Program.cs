using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (product)
            {
                case "coffee":
                    Coffee(quantity);
                    break;
                case "water":
                    Water(quantity);
                    break;
                case "coke":
                    Coke(quantity);
                    break;
                case "snacks":
                    Snacks(quantity);
                    break;
            }
        }

        private static void Snacks(int quantity)
        {
            Console.WriteLine($"{quantity * 2.00:f2}");
        }

        private static void Coke(int quantity)
        {
            Console.WriteLine($"{quantity * 1.40:f2}");
        }

        private static void Water(int quantity)
        {
            Console.WriteLine($"{quantity * 1.00:f2}");
        }

        private static void Coffee(int quantity)
        {
            Console.WriteLine($"{quantity * 1.50:f2}");
        }
    }
}
