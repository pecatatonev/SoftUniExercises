using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            //a, e, i, o, and u.
            string input = Console.ReadLine();
            input = input.ToLower();
            Vowels(input);
            
        }

        private static void Vowels(string input)
        {
            
            char currCh = ' ';
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                currCh = input[i];
                if (currCh == 'a' || currCh == 'e' || currCh == 'i' || currCh == 'o' || currCh == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
