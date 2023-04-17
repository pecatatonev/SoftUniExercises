using System;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Дължина в см – цяло число в интервала[10 … 500]
            //2.Широчина в см – цяло число в интервала[10 … 300]
            //3.Височина в см – цяло число в интервала[10… 200]
            // 4.Процент  – реално число в интервала[0.000 … 100.000]

            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());

            double percent = double.Parse(Console.ReadLine());

            double volume = lenght * width * hight;

            double liters = volume /1000;

            double occupied = percent / 100;

            double water = liters * (1 - occupied);

                Console.WriteLine( water );
        }
    }
}
