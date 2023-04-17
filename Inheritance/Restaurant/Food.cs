using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Food : Product
    {
        public Food(string name, decimal price, double grams) : base(name, price)
        {
            base.Name = name;
            base.Price = price;
            this.Grams = grams;
        }

        public double Grams { get; set; }
    }
}
