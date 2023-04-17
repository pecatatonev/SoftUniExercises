using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise.Models
{
    public class Car : Vehicle
    {
        private const double IncreasedConsum = 0.9;
        public Car(double fuelQuantity, double fuelConsumPerKM, double tankCapacity) : base(fuelQuantity, fuelConsumPerKM, tankCapacity, IncreasedConsum)
        {
        }
    }
}
