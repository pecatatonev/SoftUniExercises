using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double factorialNum1 = 1;
            double factorialNum2 = 1;
            factorialNum1 = Factorial1(num1, factorialNum1);
            factorialNum2 = Factorial2(num2, factorialNum2);

            
            Console.WriteLine($"{factorialNum1 / factorialNum2:f2}");
        }

        private static double Factorial2(int num2, double factorialNum2)
        {
            for (int i = 1; i <= num2; i++)
            {
                factorialNum2 *= i;
            }

            return factorialNum2;
        }

        private static double Factorial1(int num1, double factorialNum1)
        {
            for (int i = 1; i <= num1; i++)
            {
                factorialNum1 *= i;
            }

            return factorialNum1;
        }
    }
}
