using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                bool isFalse = false;
                for (int i = 0; i < input.Length/2; i++)
                {
                    char lastCh = input[input.Length-1-i];
                    char firstCh = input[i];
                    
                    if (lastCh != firstCh)
                    {
                        isFalse = true;
                    }
                }
                if (isFalse == true)
                {
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine("true");
                }
                input = Console.ReadLine();
            }
        }
    }
}
