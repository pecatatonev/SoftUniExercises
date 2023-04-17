using System;

namespace _02._Maiden_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double partyPrice = double.Parse(Console.ReadLine());
            int loveMessageAmount = int.Parse(Console.ReadLine());
            int rosesAmount = int.Parse(Console.ReadLine());
            int keychainAmount = int.Parse(Console.ReadLine());
            int drawingAmount = int.Parse(Console.ReadLine());
            int luckAmount = int.Parse(Console.ReadLine());

            double allPrice = loveMessageAmount * 0.60 + rosesAmount * 7.20
            + keychainAmount * 3.60 + drawingAmount * 18.20 + luckAmount * 22;
            int allAmount = loveMessageAmount + rosesAmount + keychainAmount + drawingAmount + luckAmount;

            if (allAmount > 25)
            {
                allPrice -= allPrice * 0.35;
            }

            allPrice -= allPrice * 0.1;

            if (allPrice >= partyPrice)
            {
                Console.WriteLine($"Yes! {allPrice - partyPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {partyPrice - allPrice:f2} lv needed.");
            }
        }
    }
}
