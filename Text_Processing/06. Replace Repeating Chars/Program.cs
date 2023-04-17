using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var newString = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currCh = input[i];
                if (i+1 >= input.Length)
                {
                    newString.Append(currCh);
                    break;
                }
                if (currCh != input[i+1])
                {
                    newString.Append(currCh);
                }
            }
            Console.WriteLine(newString);
        }
    }
}
