using System.Security.Principal;
List<IId> visitors = new List<IId>();
string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] inputParams = input.Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    IId visitor;
    if (inputParams.Length == 3)
    {
        visitor = new Citizen(inputParams[0], int.Parse(inputParams[1]), inputParams[2]);
        visitors.Add(visitor);
    }
    else if (inputParams.Length == 2)
    {
        visitor = new Robot(inputParams[0], inputParams[1]);
        visitors.Add(visitor);
    }
}

string lastDigits = Console.ReadLine();

foreach (var visitor in visitors)
{
    
    if (visitor.ValidateId(lastDigits))
    {
        Console.WriteLine(visitor.Id);
    }
}
