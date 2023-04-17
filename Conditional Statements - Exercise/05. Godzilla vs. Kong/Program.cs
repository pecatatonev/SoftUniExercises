using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetFilm = double.Parse(Console.ReadLine());
            int numStatisti = int.Parse(Console.ReadLine());
            double priceOfClothesStatist = double.Parse(Console.ReadLine());

            double decor = budgetFilm * 0.1;
            double allPriceOfClothesStatists = priceOfClothesStatist * numStatisti;
            double discount = 0;
            

            if (numStatisti > 150)
            {
                discount = allPriceOfClothesStatists * 0.1;
            }

            double priceForfilm = decor + (allPriceOfClothesStatists - discount);
            double lvLeft = budgetFilm - priceForfilm;

            if (priceForfilm > budgetFilm)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(lvLeft):f2} leva more.");
            }
            else if (priceForfilm <= budgetFilm)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {lvLeft:f2} leva left.");
            }
        }
    }
}
