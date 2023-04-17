using System;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split("")
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputParams = input.Split();
                string command = inputParams[0];
                switch (command)
                {
                    case "swap":
                        int index1 = 0;
                        index1 = array[int.Parse(inputParams[1])];
                        array[int.Parse(inputParams[1])] = array[int.Parse(inputParams[2])];
                        array[int.Parse(inputParams[2])] = index1;
                        break;
                    case "multiply":
                        array[int.Parse(inputParams[1])] *= array[int.Parse(inputParams[2])];
                        break;
                    case "decrease":
                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i]--;
                        }
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
