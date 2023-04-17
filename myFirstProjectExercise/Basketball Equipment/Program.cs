using System;

namespace Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneyForYearTraining = int.Parse(Console.ReadLine());

            double boots = moneyForYearTraining - moneyForYearTraining * (40 / 100.0);
            double outfit = boots - boots * (20 / 100.0);
            double ball = outfit / 4;
            double accesories = ball / 5;

            double price = moneyForYearTraining + boots + outfit + ball + accesories;

            Console.WriteLine(price);
        }
    }
}
