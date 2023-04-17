using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double priceHeadset = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int dispayCount = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 ==0)
                {
                    headsetCount++;
                }
                if (i % 3 ==0)
                {
                    mouseCount++;
                }
                if (i % 2==0 && i % 3==0)
                {
                    keyboardCount++;
                }
                if (i % 12==0)
                {
                    dispayCount++;
                }
            }

            double expenses = priceHeadset * headsetCount + priceMouse * mouseCount
                + priceKeyboard * keyboardCount + priceDisplay * dispayCount;

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
