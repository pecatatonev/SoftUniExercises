using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedTimes = int.Parse(Console.ReadLine());

            int evaluationCount = 0;
            double evaluationSum = 0;
            string lastExercise = string.Empty;
            int evaluation = 0;
            int failedCount =0;

            string input = Console.ReadLine();
            while (input != "Enough")
            {
                lastExercise = input;
                evaluation = int.Parse(Console.ReadLine());

                evaluationSum += evaluation;
                evaluationCount++;

                if (evaluation <=4)
                {
                    failedCount++;
                    if (failedCount>=failedTimes)
                    {
                        Console.WriteLine($"You need a break, {failedCount} poor grades.");
                        break;
                    }
                }

                input = Console.ReadLine();
            }

            double av = evaluationSum / evaluationCount;

            if (failedCount!=failedTimes)
            {
                Console.WriteLine($"Average score: {av:f2}");
                Console.WriteLine($"Number of problems: {evaluationCount}");
                Console.WriteLine($"Last problem: {lastExercise}");
            }
            
            
            
        }
    }
}
