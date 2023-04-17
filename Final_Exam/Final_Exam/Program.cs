using System;
using System.Text;

namespace Final_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder stringBuilder= new StringBuilder();

            stringBuilder.Append(input);

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputParams = input.Split(" ");
                string command = inputParams[0];

                if (command == "Translate")
                {
                    char bukva = char.Parse(inputParams[1]);
                    char replaceChar = char.Parse(inputParams[2]);

                    stringBuilder.Replace(bukva, replaceChar);
                    Console.WriteLine(stringBuilder);
                }
                else if (command == "Includes")
                {
                    string substiring = inputParams[1];
                    string currectString = stringBuilder.ToString();
                    
                    if (currectString.IndexOf(substiring) == -1)
                    {
                        Console.WriteLine("False");
                    }
                    else
                    {
                        Console.WriteLine("True");
                    }
                }
                else if (command == "Start")
                {
                    string substiring = inputParams[1];
                    string currectString = stringBuilder.ToString();

                    if (currectString.IndexOf(substiring) == 0)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Lowercase")
                {
                    string currectString = stringBuilder.ToString();
                    currectString = currectString.ToLower();
                    stringBuilder.Clear();
                    stringBuilder.Append(currectString);
                    Console.WriteLine(stringBuilder);
                }
                else if (command == "FindIndex")
                {
                    char currCh = char.Parse(inputParams[1]);
                    string currectString = stringBuilder.ToString();
                    Console.WriteLine(currectString.LastIndexOf(currCh));
                }
                else if (command == "Remove")
                {
                    int startIndex = int.Parse(inputParams[1]);
                    int count = int.Parse(inputParams[2]);

                    stringBuilder.Remove(startIndex, count);
                    Console.WriteLine(stringBuilder);
                }
            }
        }
    }
}
