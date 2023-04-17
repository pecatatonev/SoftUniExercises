using System;

namespace _03._Calculations
{
    class Program
    {
        private const string V = "divide";

        static void Main(string[] args)
        {
            string calculation = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            switch (calculation)
            {
                case "add":
                    Add(num1, num2);
                    break;
                case "multiply":
                    Multiply(num1, num2);
                    break;
                case "subtract":
                    Subtract(num1, num2);
                    break;
                case "divide":
                    Divide(num1, num2);
                    break;
                default:
                    break;
            }
            
        }

        private static void Divide(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }

        private static void Subtract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }

        private static void Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }

        private static void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
    }
}
