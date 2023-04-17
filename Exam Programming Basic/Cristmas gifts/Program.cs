using System;

namespace Cristmas_gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int numkids = 0;
            int numadults = 0;
            int moneytoys = 0;
            int moneysweaters = 0;

            while ( input != "Christmas")
            {
                int age = int.Parse(input);

                if (age <= 16)
                {
                    numkids += 1;
                }
                else
                {
                    numadults += 1;
                }

                input = Console.ReadLine();
            }

            moneytoys = numkids * 5;
            moneysweaters = numadults * 15;


            Console.WriteLine($"Number of adults: {numadults}");
            Console.WriteLine($"Number of kids: {numkids}");
            Console.WriteLine($"Money for toys: {moneytoys}");
            Console.WriteLine($"Money for sweaters: {moneysweaters}");
        }
    }
}
