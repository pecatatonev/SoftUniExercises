using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ")
                .ToArray();

            string firstWord = input[0];
            string secondWord = input[1];
            int sum = 0;
            if (firstWord.Length < secondWord.Length)
            {
                for (int i = 0; i < secondWord.Length; i++)
                {
                    if (i >= firstWord.Length)
                    {
                        sum += secondWord[i];
                        continue;
                    }
                    sum += firstWord[i] * secondWord[i];
                }
            }
            else
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    if (i >= secondWord.Length)
                    {
                        sum += firstWord[i];
                        continue;
                    }
                    sum += firstWord[i] * secondWord[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
