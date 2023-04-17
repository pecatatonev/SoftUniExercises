using System;

namespace RawData;

public class Startup
{

    public static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();
        for (int i = 0; i < n; i++)
        {
            string[] carProps = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            Car car = new
                (
                carProps[0],
                int.Parse(carProps[1]),
                int.Parse(carProps[2]),
                int.Parse(carProps[3]),
                carProps[4],
                float.Parse(carProps[5]),
                int.Parse(carProps[6]),
                float.Parse(carProps[7]),
                int.Parse(carProps[8]),
                float.Parse(carProps[9]),
                int.Parse(carProps[10]),
                float.Parse(carProps[11]),
                int.Parse(carProps[12])
                );

            cars.Add(car);
        }

        string command = Console.ReadLine();

        string[] filteredModels;

        if (command == "fragile")
        {
            filteredModels = cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.TirePressure < 1))
                .Select(c => c.Model)
                .ToArray();
        }
        else
        {
            filteredModels = filteredModels = cars.Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250)
                .Select(c => c.Model)
                .ToArray();
        }

        Console.WriteLine(string.Join(Environment.NewLine,filteredModels));
    }
}