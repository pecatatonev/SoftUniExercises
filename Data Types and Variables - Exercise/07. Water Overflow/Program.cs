using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int liters = 0;

            while (n>0)
            {
                int litersPour = int.Parse(Console.ReadLine());
                liters += litersPour;
                if (liters>255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    liters -= litersPour;
                    n--;
                    continue;
                }
                n--;
                
            }

            Console.WriteLine(liters);
        }
    }
}
