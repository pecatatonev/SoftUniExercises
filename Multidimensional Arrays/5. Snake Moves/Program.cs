using System;
using System.Linq;

namespace _5._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[size[0], size[1]];

            string snake = Console.ReadLine();
            int indexSnake = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row % 2 == 0)
                    {
                        matrix[row, col] = snake[indexSnake];
                    }
                    else
                    {
                        matrix[row, matrix.GetLength(1) - 1 - col] = snake[indexSnake];
                    }

                    indexSnake++;
                    if (indexSnake >= snake.Length)
                    {
                        indexSnake = 0;
                    }
                }
            }

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write(matrix[rows, cols]);
                }

                Console.WriteLine();
            }
        }
    }
}
