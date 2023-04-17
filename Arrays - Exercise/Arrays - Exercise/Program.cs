using System;
using System.Linq;

namespace Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int sum = 0;

            int[] allPeople = new int[wagons];
            for (int i = 0; i < wagons; i++)
            {
                int people = int.Parse(Console.ReadLine());
                allPeople[i] = people;
                sum += people;
            }

            for (int i = 0; i < allPeople.Length; i++)
            {
                Console.Write($"{allPeople[i]} ");
            }
            Console.WriteLine(" ");
            Console.WriteLine(sum);
        }
    }
}
