using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MiddleCharacter(input);
        }

        private static void MiddleCharacter(string input)
        {
            char midCh = ' ';
            char midCh2 = ' ';
            for (int i = 0; i < input.Length; i++)
            {
                
                midCh = input[input.Length / 2];
                if (input.Length % 2 == 0)
                {
                    midCh2 = input[input.Length / 2 - 1];
                }
            }
               
            Console.WriteLine($"{midCh2}{midCh}");
        }
    }
}
