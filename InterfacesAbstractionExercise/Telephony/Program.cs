using Telephony;
using Telephony.Models.Interfaces;

string[] phoneNumbers = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .ToArray();
string[] websites = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .ToArray();


foreach (var number in phoneNumbers)
{
    ICallable phone;

    if (number.Length == 10)
    {
        phone = new Smartphone();
    }
    else
    {
        phone = new StationaryPhone();      
    }

    try
    {
        Console.WriteLine(phone.Call(number));
    }
    catch (ArgumentException ex)
    {

        Console.WriteLine(ex.Message);
    }
}

foreach (var sites in websites)
{
    IBrowsable browse = new Smartphone();

    try
    {
        Console.WriteLine(browse.Browse(sites)); 
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}