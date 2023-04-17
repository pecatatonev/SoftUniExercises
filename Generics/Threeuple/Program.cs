using System;
using Tuple;

string[] personTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

string[] drinkTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

string[] bankTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();


MyTuple<string, string, string> nameAdress = new(personTokens[0] + " " + personTokens[1], personTokens[2], personTokens[3]);
if (personTokens.Length > 4 )
{
    nameAdress = new(personTokens[0] + " " + personTokens[1], personTokens[2], personTokens[3] + " " + personTokens[4]);
}

bool isDrunk = false;
MyTuple<string, int, bool> drinkAdress = new(drinkTokens[0], int.Parse(drinkTokens[1]), isDrunk);
if (drinkTokens[2] == "drunk")
{
    isDrunk = true;
    drinkAdress = new(drinkTokens[0], int.Parse(drinkTokens[1]),isDrunk);
}
MyTuple<string,double,string> numbersAdress = new(bankTokens[0], double.Parse(bankTokens[1]), bankTokens[2]);

Console.WriteLine(nameAdress);
Console.WriteLine(drinkAdress);
Console.WriteLine(numbersAdress);