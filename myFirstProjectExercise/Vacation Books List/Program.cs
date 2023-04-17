using System;

namespace Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesForHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int timeForTheBook = pages / pagesForHour;
            int hoursPerDay = timeForTheBook / days;

            Console.WriteLine(hoursPerDay);
        }
    }
}
