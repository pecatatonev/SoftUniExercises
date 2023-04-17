using System;
using System.Linq;

namespace Multidimensional_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];

            int sumFirstDiagonal = 0;
            int sumSecondDiagonal = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] nums = Console.ReadLine()
                       .Split()
                       .Select(int.Parse)
                       .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            for (int i = 0; i < matrixSize; i++)
            {
                sumFirstDiagonal += matrix[i, i];
            }

            for (int i = 0; i < matrixSize; i++)
            {
                sumSecondDiagonal += matrix[matrixSize-i-1, i];
            }
            int diff = 0;
            if (sumFirstDiagonal > sumSecondDiagonal)
            {
                diff = sumFirstDiagonal- sumSecondDiagonal;
            }
            else
            {
                diff= sumSecondDiagonal-sumFirstDiagonal;
            }

            Console.WriteLine(diff);
            //PrintMatrix(matrixSize, matrix);
        }

        private static void PrintMatrix(int matrixSize, int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write(matrix[rows, cols] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
