using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numCopy = num;
            int sum = 0;

            while (numCopy >0)
            {
                int lastDigit = numCopy % 10;
                numCopy /= 10;
                sum += lastDigit;
            }
            Console.WriteLine(sum);
        }
    }
}
