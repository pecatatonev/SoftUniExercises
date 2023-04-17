using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripMoney = double.Parse(Console.ReadLine());
            double herMoney = double.Parse(Console.ReadLine());

            int days = 0;
            int daysSpend = 0;

            while (herMoney<tripMoney)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                days++;

                if (action=="spend")
                {
                    herMoney = herMoney - money;
                    if (herMoney<0)
                    {
                        herMoney = 0;
                    }
                    daysSpend++;
                    if (daysSpend == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(days);
                        break;
                    }
                }

                if (action == "save")
                {
                    herMoney += money;
                    daysSpend = 0;
                }
                
                
            }

            if (tripMoney <= herMoney)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
           
        }
    }
}
