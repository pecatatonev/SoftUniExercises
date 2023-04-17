using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public class Pet : IBirth
    {
        public Pet(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public bool ValidateYear(int year)
        {
            if (Birthday.Year == year)
            {
                return true;
            }
            return false;
        }
    }
}
