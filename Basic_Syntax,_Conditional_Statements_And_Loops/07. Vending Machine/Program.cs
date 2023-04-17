
namespace _07._Vending_Machine
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            double coinsCount = 0;

            while ((input = Console.ReadLine()) != "Start")
            {
                if (input == "0.1" || input == "0.2" || input == "0.5" || input == "1" || input == "2")
                {
                    double coinsDouble = double.Parse(input);
                    coinsCount += coinsDouble;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
            }
            while (input == "Start")
            {
                
                    while (input != "End")
                    {
                        switch (input)
                        {
                            case "Nuts":
                                
                                if (coinsCount < 2)
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                    break;
                                }
                            input = input.ToLower();
                                Console.WriteLine($"Purchased {input}");
                                coinsCount -= 2;
                            break;
                            case "Water":
                                
                                if (coinsCount < 0.7)
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                    break;
                                }
                            input = input.ToLower();
                            Console.WriteLine($"Purchased {input}");
                                coinsCount -= 0.7;
                                break;
                            case "Crisps":
                                
                                if (coinsCount < 1.5)
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                    break;
                                }
                            input = input.ToLower();
                            Console.WriteLine($"Purchased {input}");
                                coinsCount -= 1.5;
                                break;
                            case "Soda":
                                
                                if (coinsCount < 0.8)
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                    break;
                                }
                            input = input.ToLower();
                            Console.WriteLine($"Purchased {input}");
                                coinsCount -= 0.8;
                                break;
                            case "Coke":
                                
                                if (coinsCount < 1)
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                    break;
                                }
                            input = input.ToLower();
                            Console.WriteLine($"Purchased {input}");
                                coinsCount -= 1;
                                break;
                            case "Start":
                                break;
                            default:
                                Console.WriteLine("Invalid product");
                                break;
                        }
                        input = Console.ReadLine();
                    }

                Console.WriteLine($"Change: {coinsCount:f2}");
                return;
            }
            
        }
    }
}
