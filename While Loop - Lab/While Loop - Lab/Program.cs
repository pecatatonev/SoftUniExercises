using System;

namespace While_Loop___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = Console.ReadLine();

            int counter = 0;


            string passInput = Console.ReadLine();

            while (passInput != pass)
            {
                counter++;
                Console.WriteLine("Wrong password");

                if (counter == 3)
                {
                    Console.WriteLine("Try again after 3 mins");
                    break;
                }
                passInput = Console.ReadLine();

            }

            if (passInput==pass)
            {
                Console.WriteLine($"Welcome {username}!");
            }
            
        }
    }
}
