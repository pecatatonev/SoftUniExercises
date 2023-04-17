﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        public Person(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public int Age { get; set; }
        public string Name { get; set; }

        public override string ToString() 
        { 
         StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.Append(String.Format($"Name: {this.Name}, Age: {this.Age}"));

            return stringBuilder.ToString();
        }
    }
}
