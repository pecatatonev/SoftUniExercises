using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < num; i++)
            {
                if (i%6 ==0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
