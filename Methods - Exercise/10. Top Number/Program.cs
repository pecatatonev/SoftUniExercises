using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastNum = int.Parse(Console.ReadLine());
            GetsTopNum(lastNum);
        }

        private static void GetsTopNum(int lastNum)
        {
            int sumOfDigits = 0;
            int currNum = 0;
            for (int i = 1; i <= lastNum; i++)
            {
                int count = 0;
                sumOfDigits = 0;
                int num = i;
                while (num != 0)
                {

                    currNum = num % 10;
                    if (currNum % 2 == 1)
                    {
                        count++;
                    }
                    sumOfDigits += currNum;
                    num /= 10;

                }
                if (count < 0)
                {
                    break;
                }
                if (sumOfDigits % 8 == 0)
                {


                    Console.WriteLine(i);

                }
            }
        }
    }
}
