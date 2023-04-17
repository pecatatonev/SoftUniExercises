using PolymorphismExercise.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise.Models
{
    public class Bus : Vehicle
    {
        private const double IncreasedConsum = 1.4;
        public Bus(double fuelQuantity, double fuelConsumPerKM, double tankCapacity) : base(fuelQuantity, fuelConsumPerKM, tankCapacity, IncreasedConsum)
        {
        }

        public override string DriveEmpty(double distance)
        {
            double totalConsumption = FuelConsumPerKM;

            if (FuelQuantity < distance * totalConsumption)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }
            FuelQuantity -= distance * totalConsumption;
            return $"{this.GetType().Name} travelled {distance} km";
        }
    }
}
