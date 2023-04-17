using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double procesorsPriceInDollars = double.Parse(Console.ReadLine());
            double videoCardPriceInDollars = double.Parse(Console.ReadLine());
            double ramPriceInDollars = double.Parse(Console.ReadLine());
            int ramAmount = int.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine());

            double procesorsPriceInLv = procesorsPriceInDollars * 1.57;
            double videoCardPriceInLv = videoCardPriceInDollars * 1.57;
            double ramPriceInLv = ramPriceInDollars * 1.57;
            double allramPriceInLv = ramPriceInLv * ramAmount;
            procesorsPriceInLv -=  procesorsPriceInLv * percentDiscount;
            videoCardPriceInLv -=  videoCardPriceInLv * percentDiscount;

            double totalPrice = allramPriceInLv + procesorsPriceInLv + videoCardPriceInLv;

            Console.WriteLine($"Money needed - {totalPrice:f2} leva.");
        }
    }
}
