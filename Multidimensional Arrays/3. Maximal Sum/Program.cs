using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] nums = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            int sum = 0;
            int biggestSum = int.MinValue;
            int startRowForMatrix = 0;
            int startColForMatrix = 0;
            for (int startIndexRows = 0; startIndexRows < matrix.GetLength(0); startIndexRows++)
            {
                if (startIndexRows + 3 > matrix.GetLength(0))
                {
                    continue;
                }
                for (int startIndexCols = 0; startIndexCols < matrix.GetLength(1); startIndexCols++)
                {
                    if (startIndexCols + 3 > matrix.GetLength(1))
                    {
                        continue;
                    }
                    for (int rows = startIndexRows; rows < startIndexRows + 3; rows++)
                    {
                        for (int cols = startIndexCols; cols < startIndexCols + 3; cols++)
                        {
                            sum += matrix[rows, cols];
                        }
                    }
                    if (sum > biggestSum)
                    {
                        startColForMatrix = startIndexCols;
                        startRowForMatrix = startIndexRows;
                        biggestSum = sum;
                        
                    }
                    sum = 0;
                }
               
            }

            Console.WriteLine($"Sum = {biggestSum} ");
            for (int rows = startRowForMatrix; rows < startRowForMatrix + 3; rows++)
            {
                for (int cols = startColForMatrix; cols < startColForMatrix + 3; cols++)
                {
                    Console.Write(matrix[rows, cols] + " ");
                }
                Console.WriteLine();
            }
               
                //Printing
                //for (int rows = 0; rows < matrix.GetLength(0); rows++)
                //{
                //    for (int cols = 0; cols < matrix.GetLength(1); cols++)
                //    {
                //        Console.Write(matrix[rows, cols] + " ");
                //    }

                //    Console.WriteLine();
                //}
            }
    }
}
