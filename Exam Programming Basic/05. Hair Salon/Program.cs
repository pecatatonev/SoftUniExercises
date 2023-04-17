using System;

namespace _05._Hair_Salon
{
    class Program
    {
        static void Main(string[] args)
        {
            int aimForDay = int.Parse(Console.ReadLine());

            

            int money = 0;
            while (money<aimForDay)
            {
                string input = Console.ReadLine();
                if (input=="closed")
                {
                    break;
                }
                switch (input)
                {
                    case "haircut":
                        input = Console.ReadLine();
                        switch (input)
                        {
                            case "mens":
                                money += 15;
                                break;
                            case "ladies":
                                money += 20;
                                break;
                            case "kids":
                                money += 10;
                                break;
                        }
                        break;
                    case "color":
                        input = Console.ReadLine();
                        switch (input)
                        {
                            case "touch up":
                                money += 20;
                                break;
                            case "full color":
                                money += 30;
                                break;
                        }
                        break;
                }
            }
            if (money >= aimForDay)
            {
                Console.WriteLine("You have reached your target for the day!");
            }
            else
            {
                Console.WriteLine($"Target not reached! You need {aimForDay - money}lv. more.");
            }
            Console.WriteLine($"Earned money: {money}lv.");
        }
    }
}
