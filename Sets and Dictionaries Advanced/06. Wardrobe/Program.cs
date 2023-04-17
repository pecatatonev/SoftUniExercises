using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> clothes
                = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] inputParam = input.Split(" -> ");

                string color = inputParam[0];
                if (!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }
                string[] clothe = inputParam[1].Split(",");

                for (int j = 0; j < clothe.Length; j++)
                {
                    if (!clothes[color].ContainsKey(clothe[j]))
                    {
                        clothes[color].Add(clothe[j], 0);
                    }
                    clothes[color][clothe[j]]++;
                }
            }

            string[] selectedClothe = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string colorSelected = selectedClothe[0];
            string clothing = selectedClothe[1];

            foreach (var color in clothes)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var clothe in color.Value)
                {
                    if (colorSelected == color.Key && clothing == clothe.Key)
                    {
                        Console.WriteLine($"* {clothe.Key} - {clothe.Value} (found!)");
                        continue;
                    }
                    Console.WriteLine($"* {clothe.Key} - {clothe.Value}");
                }
            }

        }
    }
}
