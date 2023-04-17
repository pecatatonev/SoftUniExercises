using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const decimal CoffePrice = 3.50M;
        private const double CoffeMilliliters = 50;

        public Coffee(string name,double caffeine)
            : base(name, CoffePrice, CoffeMilliliters)
        {
            Caffeine= caffeine;
        }

        public double Caffeine { get; set; }
    }
}
