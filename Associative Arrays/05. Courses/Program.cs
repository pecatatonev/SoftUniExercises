using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> courses = new Dictionary<string, int>();
            Dictionary<string, List<string>> coursesNames = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] strings = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string course = strings[0];
                string name = strings[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, 0);
                    coursesNames.Add(course, new List<string>());
                    coursesNames[course].Add(name);

                    // add names in a list and check it with the courses
                    courses[course] += 1;
                }
                else
                {
                    coursesNames[course].Add(name);
                    courses[course] += 1;
                }

                
                input = Console.ReadLine();
            }
            
            foreach (var item in courses)
            {
                string kvp = item.Key;   
                Console.WriteLine($"{kvp}: {item.Value}");
                foreach (var name in coursesNames)
                {
                    if (item.Key == name.Key)
                    {
                        Console.WriteLine($"-- { string.Join($"{Environment.NewLine}-- ", name.Value)}");
                    }
                    
                }
            }
        }
    }
}
 