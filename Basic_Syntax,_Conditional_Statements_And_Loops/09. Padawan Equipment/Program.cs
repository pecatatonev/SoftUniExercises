using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double students = int.Parse(Console.ReadLine());
            double priceLightSabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());
            double minusBelts = 0;

            double percentStudens=(students * 10 / 100);
            double roundNum= Math.Ceiling(percentStudens);
            double moneyForLightSabers = (students + roundNum) * priceLightSabers ;
          
            double moneyForRobes = students * priceRobes;
            for (int i = 1; i <= students; i++)
            {
                if (i % 6 == 0)
                {
                    minusBelts++;
                }
            }
            double moneyForBelts = (students - minusBelts) * priceBelts ;

            double allPrice = moneyForLightSabers + moneyForRobes + moneyForBelts;

            if (allPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {allPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {allPrice - money:f2}lv more.");
            }
        }
    }
}
