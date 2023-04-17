using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = Copy(input, n);
            Console.WriteLine(result);
        }

        private static string Copy(string input, int n)
        {
            string result= string.Empty;
            for (int i = 1; i <= n; i++)
            {
                result += input;
            }
            return result;
        }
    }
}
