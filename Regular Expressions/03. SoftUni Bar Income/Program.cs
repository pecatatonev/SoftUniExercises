using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[^\%\|\.\$]*?\%(?<customerName>[A-Z][a-z]+)\%[^\%\|\.\$]*?\<(?<product>[A-Za-z]+)\>[^\%\|\.\$]*?\|(?<count>\d+)\|[^\%\|\.\$]*?(?<price>\d+(\.\d+)?)\$[^\%\|\.\$]*?$";
            Regex regex = new Regex(pattern);

            string input = string.Empty;
            double totalIncome = 0;
            while ((input = Console.ReadLine()) != "end of shift")
            {
               
                Match match = regex.Match(input);

                if (match.Success)
                { 
                    string customerName = match.Groups["customerName"].Value;
                    string product = match.Groups["product"].Value;
                    double count = double.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    double total = count * price;
                    totalIncome += total;
                    Console.WriteLine($"{customerName}: {product} - {total:f2}");
                    
                }

            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
