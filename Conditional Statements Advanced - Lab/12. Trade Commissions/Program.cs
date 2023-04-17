using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double percent = 0;
            //Град    0 ≤ s ≤ 500   500 < s ≤ 1 000    1 000 < s ≤ 10 000      s > 10 000
            //Sofia   5 %            7 %                8 %                      12 %
            //Varna   4.5 %          7.5 %              10 %                     13 %
            //Plovdiv 5.5 %          8 %                12 %                     14.5 %


            switch (city)
            {
                case "Sofia":
                    if (sales >= 0 && sales <= 500)
                    {
                        percent = 0.05;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        percent = 0.07;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        percent = 0.08;
                    }
                    else
                    {
                        percent = 0.12;
                    }
                    break;
                case "Varna":
                    if (sales >= 0 && sales <= 500)
                    {
                        percent = 0.045;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        percent = 0.075;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        percent = 0.10;
                    }
                    else
                    {
                        percent = 0.13;
                    }
                    break;
                case "Plovdiv":
                    if (sales >= 0 && sales <= 500)
                    {
                        percent = 0.055;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        percent = 0.08;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        percent = 0.12;
                    }
                    else if (sales > 1000)
                    {
                        percent = 0.145;
                    }
                    break;
            }
            double commision = sales * percent;

            if (commision > 0)
            {
                Console.WriteLine($"{commision:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
            
        }
    }
}
