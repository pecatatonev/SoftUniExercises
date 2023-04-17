using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            char c = ' ';
            if ((int)a > (int)b)
            {
                c = b;
                b = a;
                a = c;

            }
            PrintsAllChBetween(a, b);

        }

        private static void PrintsAllChBetween(char a, char b)
        {
            char currCh = ' ';
            for (int i = (int)a + 1; i < (int)b; i++)
            {
                currCh = (char)i;
                Console.Write(currCh + " ");
            }
        }
    }
}
