using System;

namespace _07._House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double sideWall = x * y;
            double window = 1.5 * 1.5;
            double bothWalls = 2 * sideWall - 2 * window;
            double backWall = x * x;
            double entrance = 1.2 * 2;
            double bothEntranceAndBack = 2 * backWall - entrance;
            double S = bothEntranceAndBack + bothWalls;
            double greenPaint = S / 3.4;

            double bothRoofRectangle = (x * y) * 2;
            double bothRoofTriangle = (x * h / 2) * 2;
            double sRoof = bothRoofRectangle + bothRoofTriangle;
            double redPaint = sRoof / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
