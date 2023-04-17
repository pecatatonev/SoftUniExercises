using System;
using System.Linq;
using System.Numerics;

namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            if (size < 3)
            {
                Console.WriteLine(0);

                return;
            }
            char[,] matrix = new char[size, size];

            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string chars = Console.ReadLine();     
                for (int col = 0; col < matrix.GetLength(1); col++)
                { 
                    matrix[row, col] = chars[col];
                }
            }

            int knightsRemoved =0;

            while (true)
            {
                int countMostAttacking = 0;
                int rowMostAttacking = 0;
                int colMostAttacking = 0;

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (matrix[row,col] == 'K')
                        {
                            int attackedKnights = CountAttackedKnights(row, col,size);
                            if (countMostAttacking < attackedKnights)
                            {
                                countMostAttacking = attackedKnights;
                                rowMostAttacking = row;
                                colMostAttacking = col;
                            }
                        }
                    }
                }

                if (countMostAttacking == 0)
                {
                    break;
                }
                else
                {
                    matrix[rowMostAttacking, colMostAttacking] = '0';
                    knightsRemoved++;
                }
            }

            Console.WriteLine(knightsRemoved);

            //for (int rows = 0; rows < matrix.GetLength(0); rows++)
            //{
            //    for (int cols = 0; cols < matrix.GetLength(1); cols++)
            //    {
            //        Console.Write(matrix[rows, cols] + " ");
            //    }

            //    Console.WriteLine();
            //}
        }

        public static int CountAttackedKnights(int row, int col,int size)
        {
            int attackedKnight = 0;

            //horizontal left-up
           // if (IsCellValid(row - 1, col - 2, size))
            {
               // if ()
                {

                }
            }

            return attackedKnight;
        }

        public bool IsCellValid(int row, int col,int size)
        { 
            return 
                row >= 0
                && row < size
                && col >=0
                && col < size;
        }
    }
}
