using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfParticipants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string pattern = @"(?<names>[A-Za-z])|(?<distance>[0-9])";

            var people = new Dictionary<string, int>();

            Regex regex = new Regex(pattern);

            foreach (string person in listOfParticipants)
            {
                people.Add(person, 0);
            }

            string input = string.Empty;
            StringBuilder name = new StringBuilder();
            while ((input = Console.ReadLine()) != "end of race")
            {
                int distance = 0;
                MatchCollection namesAndDistance = regex.Matches(input);

                foreach (Match match in namesAndDistance)
                {
                    string inte = match.Groups["distance"].Value;
                    //int currDistance = int.Parse(match.Groups["distance"].Value);

                    if (int.TryParse(match.Groups["distance"].Value, out int currDistance))
                    {
                        distance += currDistance;
                    }
                    else
                    {
                        string currName = match.Groups["name"].Value;
                        name.Append(currName);
                    }

                    if (people.ContainsKey(name.ToString()))
                    {
                        people[name.ToString()] += distance;
                    }
                    name.Clear();
                }
            }

            people = people.OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, y => y.Value);

            int i = 1;
            foreach (var (currName, distance) in people)
            {
                if (i == 1)
                {
                    Console.WriteLine($"1st place: {currName}");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"2nd place: {currName}");
                }
                else if (i == 3)
                {
                    Console.WriteLine($"3rd place: {currName}");
                    break;
                }
                i++;
            }
        }
    }
}
