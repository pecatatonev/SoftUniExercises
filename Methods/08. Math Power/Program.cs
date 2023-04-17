using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double result = Result(num1, num2);
            Console.WriteLine(result);
        }

        private static double Result(double num1, int num2)
        {
            double result = 1; 
            for (int i = 0; i < num2; i++)
            {
                result *= num1;
            }
            return result;
        }
    }
}
