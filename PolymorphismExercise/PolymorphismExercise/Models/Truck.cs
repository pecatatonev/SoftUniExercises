using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise.Models
{
    public class Truck : Vehicle
    {
        private const double IncreasedConsum = 1.6;
        public Truck(double fuelQuantity, double fuelConsumPerKM,double tankCapacity) : base(fuelQuantity, fuelConsumPerKM, tankCapacity,IncreasedConsum)
        {
        }

        public override void Refuel(double liters) => base.Refuel(liters * 0.95);
    }
}
