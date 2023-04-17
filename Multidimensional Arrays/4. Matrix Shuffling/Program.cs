using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] nums = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] commandParam = command.Split(" ");

                if (commandParam[0] != "swap" || 
                    commandParam.Length > 5 || 
                    commandParam.Length < 0)
                {
                    Console.WriteLine("Invalid input!");
                    command= Console.ReadLine();
                    continue;
                }

                //later check if cordinates are valid

                int row1 = int.Parse(commandParam[1]);
                int col1 = int.Parse(commandParam[2]);
                int row2 = int.Parse(commandParam[3]);
                int col2 = int.Parse(commandParam[4]);

                if (row1 > matrix.GetLength(0) ||
                    row2 > matrix.GetLength(0) ||
                    row1 < 0 || row2 < 0)
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }
                if (col1 > matrix.GetLength(1) ||
                    col2 > matrix.GetLength(1) ||
                    col1 < 0 || col2 < 0)
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }
                string num = string.Empty;
                num = matrix[row1, col1];
                matrix[row1, col1] = matrix[row2, col2];
                matrix[row2, col2] = num;

                //Printing
                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    for (int cols = 0; cols < matrix.GetLength(1); cols++)
                    {
                        Console.Write(matrix[rows, cols] + " ");
                    }

                    Console.WriteLine();
                }
                command = Console.ReadLine();
            }
        }
    }
}
