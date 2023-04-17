using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int roomSpace = width * lenght * height;

            while (input != "Done")
            {
                int boxes = int.Parse(input);
                roomSpace -= boxes;
                if (roomSpace <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(roomSpace)} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
                

                
            }

            if (input=="Done" || roomSpace > 0)
            {
                Console.WriteLine($"{roomSpace} Cubic meters left.");
            }
            
        }
    }
}
