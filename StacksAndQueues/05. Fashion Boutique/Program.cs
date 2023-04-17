using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
               .Split(" ",StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int capacityRack = int.Parse(Console.ReadLine());

            Stack<int> clothesStack = new Stack<int>();

            for (int i = 0; i < clothes.Length; i++)
            {
                clothesStack.Push(clothes[i]);
            }
            int countRack = 1;
            int valueSum = 0;
            while (clothesStack.Count > 0)
            {
               int currClothe = clothesStack.Peek();
                
                if (valueSum + currClothe < capacityRack)
                {
                    valueSum+=clothesStack.Pop();
                }
                else if (valueSum + currClothe == capacityRack)
                {
                    valueSum += clothesStack.Pop();
                    countRack++;
                    valueSum = 0;
                }
                else if (valueSum + currClothe > capacityRack)
                {
                    countRack++;
                    valueSum = 0;
                }
            }

            Console.WriteLine(countRack);
        }
    }
}
