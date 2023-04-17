using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> items
                 = new Dictionary<string, double>();

            Dictionary<string, int> productQuantity = new Dictionary<string, int>();
            string input = Console.ReadLine();
            
            while (input != "buy")
            {
                string[] inputMasive = input.Split(" ");
                string product = inputMasive[0];
                double price = double.Parse(inputMasive[1]);
                int quantity = int.Parse(inputMasive[2]);

                if (!items.ContainsKey(product))
                {
                   
                    items.Add(product, price);
                    productQuantity.Add(product, quantity);

                }
                else
                {
                    items[product] = price;
                    productQuantity[product] += quantity;
                }

                input = Console.ReadLine();
            }
            foreach (var product in items)
            {
                foreach (var item in productQuantity)
                {
                    if (product.Key != item.Key)
                    {
                        continue;
                    }
                    Console.WriteLine($"{product.Key} -> {product.Value * item.Value:f2}");
                    break;
                }
                
            }
        }
    }
}
