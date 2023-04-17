using System.Collections.Generic;
using System.Linq;
using System;
using System.Reflection.Metadata.Ecma335;

namespace SoftUniKindergarten
{

    public class Kindergarten
    {
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; set; }

        public int ChildrenCount { get { return Registry.Count; } }
        public bool AddChild(Child child)
        {
            if (Registry.Count < Capacity)
            {
                Registry.Add(child);
                return true;
            }
            return false;
        }

        public bool RemoveChild(string childFullName)
        {
            string[] fullName = childFullName.Split(" ").ToArray();

            foreach (var child in Registry)
            {
                if (child.FirstName == fullName[0] && child.LastName == fullName[1])
                {
                    Registry.Remove(child);
                    return true;
                }
            }
            return false;
        }

        public Child GetChild(string childFullName)
        {
            string[] fullName = childFullName.Split(" ").ToArray();

            foreach (var child in Registry)
            {
                if (child.FirstName == fullName[0] && child.LastName == fullName[1])
                {
                    return child;
                }
            }

            return null;
        }

        public string RegistryReport()
        {
            var orderBy = from c in Registry 
            orderby c.Age descending, 
                    c.LastName,
                    c.FirstName
            select c;
            //Registry.OrderByDescending(c => c.Age)
            //.ThenBy(c => c.LastName)
            //.ThenBy(c => c.FirstName);
                

            return $"Registered children in {Name}:{Environment.NewLine}" +
                $"{string.Join(Environment.NewLine, orderBy)}";
        }
    }
}
