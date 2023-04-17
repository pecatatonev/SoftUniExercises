using System;

namespace DefiningClasses;

public class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Person> list = new List<Person>();
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            Person person= new Person(input[0],int.Parse(input[1]));

            if (person.Age > 30)
            {
                list.Add(person);
            }

            
        }
        
        foreach (var person in list.OrderBy(p => p.Name))
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }

    }
}