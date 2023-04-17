using System;

namespace Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double interestRate = double.Parse(Console.ReadLine());
            double sum = deposit + period * ((deposit * interestRate/100) / 12);
            Console.WriteLine(sum);
        }
    }
}
