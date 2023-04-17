using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyEmployees
                = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] amdParams = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string company = amdParams[0];
                string id = amdParams[1];

                if (!companyEmployees.ContainsKey(company))
                {
                    companyEmployees.Add(company, new List<string>());
                    companyEmployees[company].Add(id);

                    List<string> employees = companyEmployees[company];
                    if (employees.Contains(id))
                    {
                        continue;
                    }
                }
                else
                {
                    List<string> employees = companyEmployees[company];
                    if (employees.Contains(id))
                    {
                        continue;
                    }
                    companyEmployees[company].Add(id);
                }
            }

            foreach (var item in companyEmployees)
            {
                List<string> employees = item.Value;
                Console.WriteLine(item.Key);
                for (int i = 0; i < employees.Count; i++)
                {
                    Console.WriteLine($"-- {employees[i]}");
                }
            }
        }
    }
}
