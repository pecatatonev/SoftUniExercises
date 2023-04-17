using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsAndGrades
                = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsAndGrades.ContainsKey(name))
                {
                    studentsAndGrades.Add(name, new List<double>());
                    studentsAndGrades[name].Add(grade);
                }
                else
                {
                    studentsAndGrades[name].Add(grade);
                }
            }

            foreach (var item in studentsAndGrades)
            {
                List<double> grades = item.Value;

                if (studentsAndGrades[item.Key].Average() >= 4.50)
                {

                    Console.WriteLine($"{item.Key} -> {studentsAndGrades[item.Key].Average():f2}");

                }
                    
                
                
            }
        }
    }
}
