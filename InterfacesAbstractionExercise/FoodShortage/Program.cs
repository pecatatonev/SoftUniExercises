using FoodShortage;

int n = int.Parse(Console.ReadLine());

List<IBuyer> buyers = new List<IBuyer>();
for (int i = 0; i < n; i++)
{
    string[] people = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    IBuyer buyer;
    if (people.Length == 3)
    {
        buyer = new Rebel(people[0], int.Parse(people[1]), people[2]);
        buyers.Add(buyer);
    }
    else
    {
        buyer = new Citizen(people[0], int.Parse(people[1]), people[2], DateTime.ParseExact(people[3],"dd/MM/yyyy", null));
        buyers.Add(buyer);
    }
}

string name;
int allFood = 0;
while ((name = Console.ReadLine()) != "End")
{
    foreach (var buyer in buyers)
    {

        allFood += buyer.BuyFood(name);

    }

}
Console.WriteLine(allFood);