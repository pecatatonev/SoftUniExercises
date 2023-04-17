

namespace _03._Gaming_Store
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double moneySpend = 0;
            string game;
            while ((game = Console.ReadLine()) !=  "Game Time")
            {
                switch (game)
                {
                    case "OutFall 4":
                        if (balance < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        Console.WriteLine($"Bought {game}");
                        balance -= 39.99;
                        moneySpend += 39.99;
                        break;
                    case "CS: OG":
                        if (balance < 15.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        Console.WriteLine($"Bought {game}");
                        balance -= 15.99;
                        moneySpend += 15.99;
                        break;
                    case "Zplinter Zell":
                        if (balance < 19.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        Console.WriteLine($"Bought {game}");
                        balance -= 19.99;
                        moneySpend += 19.99;
                        break;
                    case "Honored 2":
                        if (balance < 59.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        Console.WriteLine($"Bought {game}");
                        balance -= 59.99;
                        moneySpend += 59.99;
                        break;
                    case "RoverWatch":
                        if (balance < 29.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        Console.WriteLine($"Bought {game}");
                        balance -= 29.99;
                        moneySpend += 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        if (balance < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        Console.WriteLine($"Bought {game}");
                        balance -= 39.99; 
                        moneySpend += 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

            }
            if (balance > 0)
            {
                Console.WriteLine($"Total spent: ${moneySpend:f2}. Remaining: ${balance:f2}");
            }
        }
    }
}
