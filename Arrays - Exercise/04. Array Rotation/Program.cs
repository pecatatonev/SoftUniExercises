

namespace _04._Array_Rotation
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());


            int timesToRotate = n % numbers.Length;
            for (int r = 1; r <= timesToRotate; r++)
            {
                int firstEl = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    numbers[i - 1] = numbers[i];
                }
                numbers[numbers.Length - 1] = firstEl;
            }

            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
