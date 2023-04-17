using System;
using System.Collections.Generic;

namespace Final_Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string,int> carMileage = new Dictionary<string, int>();
            Dictionary<string,int> carFuel = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string inputCars = Console.ReadLine();
                string[] inputParams = inputCars.Split("|",StringSplitOptions.RemoveEmptyEntries);

                string car = inputParams[0];
                int carMileageID = int.Parse(inputParams[1]);
                int carFuelcurr = int.Parse(inputParams[2]);

                carMileage[car] = carMileageID;
                carFuel[car] = carFuelcurr;

            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] inputParams = input.Split(" : ",StringSplitOptions.RemoveEmptyEntries);
                string command = inputParams[0];

                if (command == "Drive")
                {
                    string currCar = inputParams[1];
                    int distance = int.Parse(inputParams[2]);
                    int fuelForUse = int.Parse(inputParams[3]);

                    if (carFuel[currCar] < fuelForUse)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        carMileage[currCar] += distance;
                        carFuel[currCar] -= fuelForUse;
                        Console.WriteLine($"{currCar} driven for {distance} kilometers. {fuelForUse} liters of fuel consumed.");
                        if (carMileage[currCar] > 100000)
                        {
                            carMileage.Remove(currCar);
                            carFuel.Remove(currCar);
                            Console.WriteLine($"Time to sell the {currCar}!");
                        }
                    }
                }
                else if (command == "Refuel")
                {
                    string currCar = inputParams[1];
                    int fuelForUse = int.Parse(inputParams[2]);

                    if (carFuel[currCar] + fuelForUse > 75)
                    {
                        int allFuel = carFuel[currCar] + fuelForUse;
                        allFuel -= 75;
                        fuelForUse -= allFuel;
                        carFuel[currCar] += fuelForUse;
                        Console.WriteLine($"{currCar} refueled with {fuelForUse} liters");
                    }
                    else
                    {
                        carFuel[currCar] += fuelForUse;
                        Console.WriteLine($"{currCar} refueled with {fuelForUse} liters");
                    }
                }
                else if (command == "Revert")
                {
                    string currCar = inputParams[1];
                    int kilometres = int.Parse(inputParams[2]);

                    carMileage[currCar] -= kilometres;
                    Console.WriteLine($"{currCar} mileage decreased by {kilometres} kilometers");
                    if (carMileage[currCar] < 10000)
                    {
                        carMileage[currCar] = 10000;
                    }
                }
              
            }
            foreach (var (car,carMil) in carMileage)
            {
                
                    Console.WriteLine($"{car} -> Mileage: {carMil} kms, Fuel in the tank: {carFuel[car]} lt.");
                
            }
            //"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt."
        }
    }
}
