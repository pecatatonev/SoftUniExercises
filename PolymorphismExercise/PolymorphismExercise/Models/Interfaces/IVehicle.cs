using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise.Models.Interfaces
{
    public interface IVehicle
    {
        double TankCapacity { get; }
        double FuelQuantity { get; }

        double FuelConsumPerKM { get; }

        string Drive(double distance);

        void Refuel(double liters);

        string DriveEmpty(double distance);
    }
}
