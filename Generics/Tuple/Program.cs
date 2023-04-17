using Tuple;

string[] personTokens = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

string[] drinkTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

string[] numbersTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

MyTuple<string, string> nameAdress = new(personTokens[0] + " " + personTokens[1], personTokens[2]);

MyTuple<string, int> drinkAdress = new(drinkTokens[0], int.Parse(drinkTokens[1]));

MyTuple<int, double> numbersAdress = new(int.Parse(numbersTokens[0]), double.Parse(numbersTokens[1]));

Console.WriteLine(nameAdress);
Console.WriteLine(drinkAdress);
Console.WriteLine(numbersAdress);