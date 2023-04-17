public class Robot : IId
{
    public Robot(string model, string id)
    {
        Model = model;
        Id = id;
    }

    public string Model { get; set; }
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