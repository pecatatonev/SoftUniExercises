using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string seasons = Console.ReadLine();

            string destination = "";
            string typeVac = "";
            double moneySpend = 0;

            if (budjet <= 100 )
            {
                destination = "Bulgaria";
                if (seasons == "summer")
                {
                    moneySpend = budjet * 0.3;
                    typeVac = "Camp";
                }
                else if (seasons == "winter")
                {
                    moneySpend = budjet * 0.7;
                    typeVac = "Hotel";
                }
            }
            else if (budjet <= 1000)
            {
                destination = "Balkans";
                if (seasons == "summer")
                {
                    moneySpend = budjet * 0.4;
                    typeVac = "Camp";
                }
                else if (seasons == "winter")
                {
                    moneySpend = budjet * 0.8;
                    typeVac = "Hotel";
                }
            }
            else if (budjet > 1000)
            {
                destination = "Europe";
                moneySpend = budjet * 0.9;
                typeVac = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeVac} - {moneySpend:f2}");
        }
    }
}
