//Energy Drinks
int[] miligramsCaffeine = Console.ReadLine()
    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[] energyDrinks = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();


Stack<int> miligrams = new Stack<int>(miligramsCaffeine);
Queue<int> energy = new Queue<int>(energyDrinks);

int drankCaffeine = 0;

while (miligrams.Count != 0 && energy.Count != 0)
{
    drankCaffeine += miligrams.Peek() * energy.Peek();
    if (drankCaffeine <= 300)
    {
        miligrams.Pop();
        energy.Dequeue();
    }
    else if (drankCaffeine > 300)
    {
        int currDrink = energy.Peek();
        drankCaffeine -= miligrams.Pop() * energy.Dequeue();
        energy.Enqueue(currDrink);
        if (drankCaffeine - 30 < 0)
        {
            int diff = drankCaffeine - 30;
            drankCaffeine -= 30 + (diff);
            continue;
        }
        drankCaffeine -= 30;
    }
}


if (energy.Count > 0)
{
    Console.WriteLine($"Drinks left: {string.Join(", ",energy)}");
}
else if(energy.Count == 0)
{
    Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
}
Console.WriteLine($"Stamat is going to sleep with {drankCaffeine} mg caffeine.");