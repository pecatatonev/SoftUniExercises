using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> strings = new Stack<string>();
            string text = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = input[0];
                string param = string.Empty;
                if (command != "4")
                {
                   param = input[1];
                }

                
                switch (command)
                {
                    case "1":
                        text = text.Insert(text.Length, param);
                        strings.Push(text);
                        break; 
                    case "2":
                        text = text.Remove(text.Length - int.Parse(param), int.Parse(param));
                        strings.Push(text);
                        break; 
                    case "3":
                        int index = int.Parse(param);
                        Console.WriteLine(text.ElementAt(index - 1)); 
                        break; 
                    case "4":
                        strings.Pop();
                        if (strings.Count == 0)
                        {
                            text = string.Empty;
                            continue;
                        }
                        text = strings.Peek();
                        break;
                }


            }
        }
    }
}
