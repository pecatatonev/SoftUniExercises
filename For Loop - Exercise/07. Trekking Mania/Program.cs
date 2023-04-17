using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            double musala = 0;
            double monblan = 0;
            double kilimindjaro = 0;
            double k2 = 0;
            double everest = 0;


            for (int i = 0; i < n; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());

                if (peopleInGroup <= 5)
                {
                    musala += peopleInGroup;
                }
                else if (peopleInGroup <= 12)
                {
                    monblan += peopleInGroup;
                }
                else if (peopleInGroup <= 25)
                {
                    kilimindjaro += peopleInGroup;
                }
                else if (peopleInGroup <= 40)
                {
                    k2 += peopleInGroup;
                }
                else if (peopleInGroup >= 41)
                {
                    everest += peopleInGroup;
                }
                sum += peopleInGroup;
            }

            musala = musala / sum * 100;
            monblan = monblan / sum * 100;
            kilimindjaro = kilimindjaro / sum * 100;
            k2 = k2 / sum * 100;
            everest = everest / sum * 100;

            Console.WriteLine($"{musala:f2}%");
            Console.WriteLine($"{monblan:f2}%");
            Console.WriteLine($"{kilimindjaro:f2}%");
            Console.WriteLine($"{k2:f2}%");
            Console.WriteLine($"{everest:f2}%");
        }
    }
}
