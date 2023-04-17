using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstn = int.Parse(Console.ReadLine());
            int secondn = int.Parse(Console.ReadLine());

            for (int i = firstn; i <= secondn; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
