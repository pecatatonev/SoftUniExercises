using System;

namespace MId_Exam_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourSinglePrice = double.Parse(Console.ReadLine());
            double eggSinglePrice = double.Parse(Console.ReadLine());
            double apronSinglePrice = double.Parse(Console.ReadLine());

            double apronPrice = apronSinglePrice * (students + Math.Ceiling(students * 0.2));
            double eggPrice = eggSinglePrice * 10 * students;

            int freePackages = students / 5;
            
            double flourPrice = flourSinglePrice * (students - freePackages);

            double allPrice = apronPrice + eggPrice + flourPrice;
            if (budget >= allPrice)
            {
                Console.WriteLine($"Items purchased for {allPrice:f2}$.");
            }
            else if (budget < allPrice)
            {
                Console.WriteLine($"{allPrice - budget:f2}$ more needed.");
            }
        }
    }
}
