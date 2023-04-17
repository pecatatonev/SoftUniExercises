using System;
using System.Collections.Generic;
using System.Linq;

namespace Associative_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> texts
                = new Dictionary<char,int>();

            string[] input = Console.ReadLine().Split(" ").ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                char[] charArr = input[i].ToCharArray();
                foreach (var bukva in charArr)
                {
                    if (!texts.ContainsKey(bukva))
                    {
                        texts.Add(bukva, 0);
                    }

                    texts[bukva] += 1;
                }
            }
            texts.Remove(' ');
            foreach (var item in texts)
            {
                
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


        }
    }
}
