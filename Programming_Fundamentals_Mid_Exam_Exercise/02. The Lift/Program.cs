using System;
using System.Linq;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] currState = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < currState.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    
                    if (currState[i] == 4)
                    {

                        break;
                    }
                    currState[i] += 1;
                    people -= 1;
                    if (people <= 0)
                    {
                        break;
                    }
                    

                }
                if (people <= 0)
                {
                    break;
                }
            }

            if (people <= 0 && currState[currState.Length-1] < 4)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ",currState));
            }
            else if (people > 0 )
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", currState));
            }
            else if (people <= 0 && currState[currState.Length-1] >= 4)
            {
                Console.WriteLine(string.Join(" ", currState));
            }
        }
    }
}
