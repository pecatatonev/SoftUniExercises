using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfSkumriq = double.Parse(Console.ReadLine());
            double priceOfCaca = double.Parse(Console.ReadLine());
            double kilosofPalamud = double.Parse(Console.ReadLine());
            double kilosOfSafrid = double.Parse(Console.ReadLine());
            int kilosOfMidi = int.Parse(Console.ReadLine());

            double priceOfPalamud = priceOfSkumriq * 0.6 + priceOfSkumriq;
            double moneyForPalamud = priceOfPalamud * kilosofPalamud;
            double priceOfSafrid = priceOfCaca * 0.8 + priceOfCaca;
            double moneyForSafrid = priceOfSafrid * kilosOfSafrid;
            double moneyForMidi = kilosOfMidi * 7.50;

            double moneyNeeded = moneyForPalamud + moneyForSafrid + moneyForMidi;

            Console.WriteLine($"{moneyNeeded:f2}");
        }
    }
}
