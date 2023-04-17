using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<furniture>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+){0,1}";
            string input = string.Empty;
            double sum = 0;
            var furnitures = new List<string>();
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(input,pattern);
                if (match.Success)
                {
                    string furniture = match.Groups["furniture"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    furnitures.Add(furniture);
                    sum += price * quantity;
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var fur in furnitures)
            {
                Console.WriteLine(fur);
            }
           
            Console.WriteLine($"Total money spend: {sum:f2}");

        }
    }
}
