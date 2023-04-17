using PolymorphismExercise.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise.Models
{
    public class Vehicle : IVehicle
    {
        private double tankCapacity;
        private double increasedConsumption;
        protected Vehicle(double fuelQuantity, double fuelConsumPerKM,double tankCapacity ,double increasedConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumPerKM = fuelConsumPerKM;
            TankCapacity = tankCapacity;
            this.increasedConsumption = increasedConsumption;
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumPerKM { get; private set; }

        public double TankCapacity 
        { 
            get 
            {
                return tankCapacity;
            }
            private set
            {
                tankCapacity = value;
                if (FuelQuantity > tankCapacity)
                {
                    FuelQuantity = 0;
                }
                
            } 
        }

        public string Drive(double distance)
        {
            double totalConsumption = FuelConsumPerKM + increasedConsumption;

            if (FuelQuantity < distance * totalConsumption)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }
            FuelQuantity -= distance * totalConsumption;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public virtual string DriveEmpty(double distance)
        {
            throw new NotImplementedException();
        }

        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (liters + FuelQuantity > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                FuelQuantity += liters;
            }
            
        }


        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";

        }
    }
}
