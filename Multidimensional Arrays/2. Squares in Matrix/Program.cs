using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();

            //int row = nums[0];
            //int col = nums[1];
            //char[,] matrix = new char[row, col];

            //for (int rows = 0; rows < matrix.GetLength(0); rows++)
            //{
            //    char[] ch = Console.ReadLine()
            //           .Split()
            //           .Select(char.Parse)
            //           .ToArray();
            //    for (int cols = 0; cols < matrix.GetLength(1); cols++)
            //    {
            //        matrix[rows, cols] = ch[cols];
            //    }
            //}
            //int count = 0;
            //for (int rows = 0; rows < matrix.GetLength(0); rows++)
            //{
            //    for (int cols = 0; cols < matrix.GetLength(1); cols++)
            //    {
            //        if (rows + 1 < matrix.GetLength(0) && cols + 1 < matrix.GetLength(1) )
            //        {
            //            if (matrix[rows, cols] == matrix[rows + 1, cols]
            //            && matrix[rows, cols + 1] == matrix[rows, cols]
            //            && matrix[rows + 1, cols + 1] == matrix[rows, cols])
            //            {
            //                count++;
            //            }
            //        }


            //    }
            //}

            //Console.WriteLine(count);

            //for (int rows = 0; rows < rows; rows++)
            //{
            //    for (int cols = 0; cols < cols; cols++)
            //    {
            //        Console.Write(matrix[row, col] + " ");
            //    }

            //    Console.WriteLine();
            //}

            //----------------------------------------------
            int[] dimensions = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[dimensions[0],dimensions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] chars = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = chars[col];
                }
            }

            int count = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row,col] == matrix[row, col + 1]
                        && matrix[row, col] == matrix[row + 1, col + 1]
                        && matrix[row, col] == matrix[row + 1, col])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
