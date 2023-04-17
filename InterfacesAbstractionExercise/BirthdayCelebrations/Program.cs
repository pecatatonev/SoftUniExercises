using BirthdayCelebrations;
using System.Globalization;
using System.Security.Principal;
List<IBirth> visitors = new List<IBirth>();
List<IId> robots = new List<IId>();
string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] inputParams = input.Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    IBirth visitor;
    if (inputParams[0] == "Citizen")
    {
        visitor = new Citizen(inputParams[1],int.Parse(inputParams[2]), inputParams[3], DateTime.ParseExact(inputParams[4], "dd/MM/yyyy", null));
        visitors.Add(visitor);
    }
    else if (inputParams[0] == "Robot")
    {
        IId robot = new Robot(inputParams[1], inputParams[2]);
        robots.Add(robot);
    }
    else if (inputParams[0] == "Pet")
    {
        visitor = new Pet(inputParams[1], DateTime.ParseExact(inputParams[2],"dd/MM/yyyy", null));
        visitors.Add(visitor);
    }
}

int year = int.Parse(Console.ReadLine());

foreach (var visitor in visitors)
{
    
    if (visitor.ValidateYear(year))
    {
        Console.WriteLine(visitor.Birthday.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture));
    }
}
