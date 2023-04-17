using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray= new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                jaggedArray[row] = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
            }

            for (int row = 0; row < rows; row++)
            {
                if (row + 1 >= rows)
                {
                    continue;
                }
                if (jaggedArray[row].Length == jaggedArray[row+1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                        
                    }
                    for (int col = 0; col < jaggedArray[row+1].Length; col++)
                    {
                        jaggedArray[row + 1][col] /= 2;
                    }
                }
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandParam = command.Split(" ");

                string comm = commandParam[0];
                int row = int.Parse(commandParam[1]);
                int col = int.Parse(commandParam[2]);
                int value = int.Parse(commandParam[3]);

                switch (comm)
                {
                    case "Add":
                        if (row < rows && row >= 0 
                            && col < jaggedArray[row].Length
                            && col >= 0 )
                        {
                            jaggedArray[row][col] += value;
                        }
                        break;
                    case "Subtract":
                        if (row < rows && row >= 0
                            && col < jaggedArray[row].Length
                            && col >= 0)
                        {
                            jaggedArray[row][col] -= value;
                        }
                        break;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
