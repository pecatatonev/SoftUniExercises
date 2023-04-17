using System;

namespace _04._Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            double allLitres = 0;
            double allDegrees = 0;

            for (int i = 1; i <= days; i++)
            {
                double litresRakia = double.Parse(Console.ReadLine());
                double degreeRakia = double.Parse(Console.ReadLine());

                allLitres += litresRakia;
                allDegrees += degreeRakia *litresRakia;
            }

            double avarageDegree = allDegrees / allLitres;

            Console.WriteLine($"Liter: {allLitres:f2}");
            Console.WriteLine($"Degrees: {avarageDegree:f2}");
            if (avarageDegree < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (avarageDegree >= 38 && avarageDegree <= 42)
            {
                Console.WriteLine("Super!");
            }
            else
            {
                Console.WriteLine("Dilution with distilled water!");
            }     
        }
    }
}
