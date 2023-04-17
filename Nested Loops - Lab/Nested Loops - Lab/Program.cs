using System;

namespace Nested_Loops___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;

            for (int day = 0; day <= 30; day++)
            {
                for (int hour = 0; hour <= 23; hour++)
                {
                    for (int min = 0; min <= 59; min++)
                    {
                        Console.WriteLine($"{hour:d2}:{min:d2}");

                        if (hour == 22 && min == 30)
                        {
                            Environment.Exit(0);

                        }
                    }


                }

            }
        }
    }
}