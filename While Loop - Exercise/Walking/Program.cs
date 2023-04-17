using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int allSteps = 0;
            while (true)
            {
                if (allSteps > 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{allSteps - 10000} steps over the goal!");
                    break;
                }
                string input = Console.ReadLine();
                if (input == "Going home")
                {

                    int stepsToHome = int.Parse(Console.ReadLine());
                    allSteps += stepsToHome;

                    if (allSteps < 10000)
                    {
                        Console.WriteLine($"{10000 - allSteps} more steps to reach goal.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{allSteps - 10000} steps over the goal!");
                        break;
                    }

                }

                int steps = int.Parse(input);
                allSteps += steps;

               

                
                
            }

        }
    }
}
