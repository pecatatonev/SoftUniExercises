using ShoppingSpree;

List<Person> people = new();
List<Product> products = new();
try
{
    string[] nameMoneyPairs = Console.ReadLine()
    .Split(";", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

    for (int i = 0; i < nameMoneyPairs.Length; i++)
    {
        string[] peopleParams = nameMoneyPairs[i]
            .Split("=",StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        Person person = new(peopleParams[0], decimal.Parse(peopleParams[1]));
       
        people.Add(person);
    }

    string[] productCostPairs = Console.ReadLine()
   .Split(";", StringSplitOptions.RemoveEmptyEntries)
   .ToArray();

    for (int i = 0; i < productCostPairs.Length; i++)
    {
        string[] productParams = productCostPairs[i]
            .Split("=", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        Product product = new(productParams[0], decimal.Parse(productParams[1]));

        products.Add(product);
    }
}
catch (Exception a)
{
	Console.WriteLine(a.Message);
	return;
}

string input = string.Empty;
while ((input = Console.ReadLine()) != "END")
{
    string[] personProduct = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string personName = personProduct[0];
    string productName = personProduct[1];

    Person person = people.FirstOrDefault(p => p.Name == personName);
    Product product = products.FirstOrDefault(p => p.Name == productName);

    if (person is not null && product is not null)
    {
        Console.WriteLine(person.Add(product));
    }
}

Console.WriteLine(string.Join(Environment.NewLine, people));