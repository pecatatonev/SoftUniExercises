using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEff = int.Parse(Console.ReadLine());
            int secondEmployeeEff = int.Parse(Console.ReadLine());
            int thirdEmployeeEff = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int answersHours = firstEmployeeEff + secondEmployeeEff + thirdEmployeeEff;
            int time = 0;
            while (students > 0)
            {
                time++;
                if (time % 4 == 0)
                {
                    continue;
                }
                
                students -= answersHours;
               
            }

            Console.WriteLine($"Time needed: {time}h.");
        }
    }
}
