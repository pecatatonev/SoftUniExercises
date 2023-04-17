using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Message_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());

            string pattern = @"\!(?<command>[A-Z][a-z]{2,})\!\:\[(?<word>[A-Za-z]{8,})\]";
            Regex regex= new Regex(pattern);
            List<int> nums = new List<int>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match= regex.Match(input);
                if (!match.Success)
                {
                    Console.WriteLine("The message is invalid");
                }
                else
                {
                    string command = match.Groups["command"].Value;
                    string word = match.Groups["word"].Value;
                    for (int j = 0; j < word.Length; j++)
                    {
                        char currCh = word[j];
                        
                        nums.Add(currCh);
                       
                    }
                    Console.WriteLine($"{command}: {string.Join(" ", nums)}");
                }
            }
        }
    }
}
