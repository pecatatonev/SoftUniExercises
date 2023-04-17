using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double distanceInMetres = double.Parse(Console.ReadLine());
            double secForMetre = double.Parse(Console.ReadLine());

            double secForSwim = distanceInMetres * secForMetre;
            double supp = (distanceInMetres / 15);
            double suppmath = Math.Floor(supp);
            double allsupp = suppmath * 12.5;
            double secIvan = allsupp + secForSwim;

            double difference = recordInSec - secIvan;

            if (recordInSec <= secIvan)
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(difference):f2} seconds slower." ); 
            }
            else if (recordInSec > secIvan)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {secIvan:f2} seconds.");
            }
        }
    }
}
