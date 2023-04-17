using System;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //Reverse a string and print
            for (int i = input.Length - 1; i >= 0; i--)
            {
                char currCh = input[i];
                Console.Write(currCh);
            }
        }
    }
}
