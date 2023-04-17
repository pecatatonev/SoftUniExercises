
namespace _03._Rounding_Numbers
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] roundedNums = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
            }
            Console.WriteLine(roundedNums + " ");

        }
    }
}
