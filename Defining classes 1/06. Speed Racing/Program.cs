using _06.SpeedRacing;

int n = int.Parse(Console.ReadLine());
List<Car> carlist = new List<Car>();
for (int i = 0; i < n; i++)
{
    string[] input1 = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries);

    Car car = new(input1[0], double.Parse(input1[1]), double.Parse(input1[2]));
    carlist.Add(car);
}

string input = Console.ReadLine();

while (input != "End")
{
    string[] inputParam = input
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string command = inputParam[0];
    if (command == "Drive")
    {
        string carModel = inputParam[1];
        double amountOfKM = double.Parse(inputParam[2]);

        foreach (var car in carlist)
        {
            if (car.Model == carModel)
            {
                car.Drive(carModel, amountOfKM);
            }
        }
    }

    input = Console.ReadLine();
}

foreach (var car in carlist)
{
    Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
}
