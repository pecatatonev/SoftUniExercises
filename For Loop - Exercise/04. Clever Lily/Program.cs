using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toys = 0;
            int money = 0;

            for (int i = 1; i <=age; i++)
            {
                if (i % 2 == 0 )
                {
                    money += i*5;
                    money -= 1;
                }
                else
                {
                    toys += 1;
                }
            }

            money += toys * toyPrice;

            double diff = Math.Abs(money - washingMachine);

            if (money >= washingMachine)
            {
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                Console.WriteLine($"No! {diff:f2}");
            }
        }
    }
}
