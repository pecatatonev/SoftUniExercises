using System;

namespace Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int litres = int.Parse(Console.ReadLine());

            int discountRate = int.Parse(Console.ReadLine());

            double pricePens = pens * 5.80;
            double priceMarkers = markers * 7.20;
            double priceLitres = litres * 1.20;

            double sumProducts = priceLitres + priceMarkers + pricePens;

            double sumDiscount = sumProducts - sumProducts * (discountRate / 100.0);

            Console.WriteLine(sumDiscount);
        }
    }
}
