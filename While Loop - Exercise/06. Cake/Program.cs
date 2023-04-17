using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int cakeS = width * lenght;

            while (cakeS > 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    Console.WriteLine($"{cakeS} pieces are left.");
                    break;
                }
                int pieces =int.Parse(input);

                cakeS = cakeS - pieces;

               
            }

            if (cakeS<=0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakeS)} pieces more.");
            }
        }
    }
}
