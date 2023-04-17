using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            string input =Console.ReadLine();

            int absValue = Math.Abs(int.Parse(input));

            int sumOfEvenDigits = GetSumOfEvenDigits(absValue.ToString());
            int sumOfOddDigits = GetSumOfOddDigits(absValue.ToString());

            int result = sumOfEvenDigits * sumOfOddDigits;
            Console.WriteLine(result);


        }

        private static int GetSumOfEvenDigits(string input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber =int.Parse(input[i].ToString());

                if (currentNumber % 2 ==0)
                {
                    sum += currentNumber;
                }
            }
            return sum;
        }
        private static int GetSumOfOddDigits(string input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber = int.Parse(input[i].ToString());

                if (currentNumber % 2 != 0)
                {
                    sum += currentNumber;
                }
            }
            return sum;
        }
        }
}
