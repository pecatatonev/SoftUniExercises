using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            string input = Console.ReadLine();

            while (input != "Stop")
            {
                int n = int.Parse(input);
                if (n < minNumber)
                {
                    minNumber = n;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(minNumber);
        }
    }
}
