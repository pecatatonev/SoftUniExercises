List<string> people = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

Dictionary<string, Predicate<string>> filters = new();
string command = Console.ReadLine();
while (command != "Print")
{
    string[] tokens = command
        .Split(";", StringSplitOptions.RemoveEmptyEntries);

    string action = tokens[0];
    string filter = tokens[1];
    string value = tokens[2];

    switch (action)
    {
        case "Add filter":
            filters.Add(filter + value, GetPredicate(filter, value));
            break;
        case "Remove filter":
            filters.Remove(filter + value);
            break;
    }

    command = Console.ReadLine();
}

foreach (var filter in filters)
{
    people.RemoveAll(filter.Value);
}
    Console.WriteLine(String.Join(" ", people));


static Predicate<string> GetPredicate(string filter, string value)
{
    switch (filter)
    {
        case "Starts with":
            return p => p.StartsWith(value);
        case "Ends with":
            return p => p.EndsWith(value);
        case "Length":
            return p => p.Length == int.Parse(value);
        case "Contains":
            return p=> p.Contains(value);
        default:
            return default;
    }
}