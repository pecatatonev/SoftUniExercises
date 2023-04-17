using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double rating = double.Parse(Console.ReadLine());

            int grade = 1;

            double avarageRating = rating;

            while (grade < 12)
            {
         

                if (rating < 4.00)
                {
                    Console.WriteLine($"{name} has been excluded at {grade} grade");
                    break;
                }

                rating = double.Parse(Console.ReadLine());
                avarageRating += rating;
                grade++;
            }

            avarageRating = avarageRating / grade;

            if (grade==12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {avarageRating:f2}");
            }
            

            
        }
    }
}
