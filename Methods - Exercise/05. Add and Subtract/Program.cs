using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = 0;
            int substract = 0;
            sum = SumFromFirstTwoIntegers(num1, num2);
            substract = SubstractTHeThirdInteger(sum, num3);

            Console.WriteLine(substract);
        }

        private static int SubstractTHeThirdInteger(int sum, int num3)
        {
            int substarct1 = sum - num3;
            return substarct1;
        }

        private static int SumFromFirstTwoIntegers(int num1, int num2)
        {
            int sum1 = num1 + num2;
            return sum1;
        }
    }
}
