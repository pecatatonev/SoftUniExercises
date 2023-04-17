using PolymorphismExercise.Factories.Interfaces;
using PolymorphismExercise.Models;
using PolymorphismExercise.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise.Factories
{
    public class VehicleFactory : IVehicleFactory
    {
        public IVehicle Create(string type, double fuelQuantity, double fuelConsumPerKM,double tankCapacity)
        {
            switch (type)
            {
                case "Car":
                    return new Car(fuelQuantity, fuelConsumPerKM, tankCapacity);
                case "Truck":
                    return new Truck(fuelQuantity, fuelConsumPerKM, tankCapacity);
                case "Bus":
                    return new Bus(fuelQuantity, fuelConsumPerKM, tankCapacity);
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }
    }
}
