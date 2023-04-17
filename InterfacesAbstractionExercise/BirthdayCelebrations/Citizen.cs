using BirthdayCelebrations;

public class Citizen : IId, IBirth
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

    public bool ValidateId(string input)
    {
        if (Id.EndsWith(input))
        {
            return true;
        }

        return false;
    }

    public bool ValidateYear(int year)
    {
        if (Birthday.Year == year)
        {
            return true;
        }
        return false;
    }
}