

using FoodShortage;
using System.Net.Http.Headers;

public class Citizen : IBuyer
{
    public Citizen(string name, int age, string id, DateTime birthday)
    {
        Name = name;
        Age = age;
        Id = id;
        Birthday = birthday;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string Id { get; set; }
    public DateTime Birthday { get; set; }

    public int Food { get; set; }

    public int BuyFood(string name)
    {
        if (Name == name)
        {
            Food += 10;
            return 10;
        }
        return 0;
    }

    //public bool ValidateId(string input)
    //{
    //    if (Id.EndsWith(input))
    //    {
    //        return true;
    //    }

    //    return false;
    //}

    //public bool ValidateYear(int year)
    //{
    //    if (Birthday.Year == year)
    //    {
    //        return true;
    //    }
    //    return false;
    //}
}