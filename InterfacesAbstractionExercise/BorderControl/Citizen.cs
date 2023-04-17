public class Citizen : IId
{
    public Citizen(string name, int age, string id)
    {
        Name = name;
        Age = age;
        Id = id;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string Id { get; set; }

    public bool ValidateId(string input)
    {
        if (Id.EndsWith(input))
        {
            return true;
        }

        return false;
    }
}