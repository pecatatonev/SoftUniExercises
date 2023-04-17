//Apocalypse Preparation

Queue<int> textiles = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
Stack<int> medicaments = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));

Dictionary<string, int> craftedItems = new Dictionary<string, int>();

while (textiles.Count != 0 && medicaments.Count != 0)  
{
    int sumOfMaterials = 0; 
    sumOfMaterials += textiles.Peek() + medicaments.Peek();

    if (sumOfMaterials == 100)
	{
		if (!craftedItems.ContainsKey("MedKit"))
		{
            craftedItems.Add("MedKit", 1);
            textiles.Dequeue();
            medicaments.Pop();
			continue;
		}
        craftedItems["MedKit"]++;
        textiles.Dequeue();
        medicaments.Pop();


    }
    else if (sumOfMaterials == 40)
    {
        if (!craftedItems.ContainsKey("Bandage"))
        {
            craftedItems.Add("Bandage", 1);
            textiles.Dequeue();
            medicaments.Pop();
            continue;
        }
        craftedItems["Bandage"]++;
        textiles.Dequeue();
        medicaments.Pop();

    }
    else if (sumOfMaterials == 30)
    {
        if (!craftedItems.ContainsKey("Patch"))
        {
            craftedItems.Add("Patch", 1);
            textiles.Dequeue();
            medicaments.Pop();
            continue;
        }
        craftedItems["Patch"]++;
        textiles.Dequeue();
        medicaments.Pop();

    }
    else if (sumOfMaterials > 100)
    {
        if (!craftedItems.ContainsKey("MedKit"))
        {
            craftedItems.Add("MedKit", 1); 
            sumOfMaterials -= 100;
            medicaments.Pop();
            sumOfMaterials += medicaments.Pop();
            medicaments.Push(sumOfMaterials);
            textiles.Dequeue();
            continue;
        }
        craftedItems["MedKit"]++;
        sumOfMaterials -= 100;
        medicaments.Pop();
        sumOfMaterials += medicaments.Pop();
        medicaments.Push(sumOfMaterials);
        textiles.Dequeue();
    }
    else
    {
        int push = 10;
        textiles.Dequeue();
        push += medicaments.Pop();
        medicaments.Push(push);
        
    }
}

if (textiles.Count == 0 && medicaments.Count == 0)
{
    Console.WriteLine("Textiles and medicaments are both empty.");
}
else if (textiles.Count == 0)
{
    Console.WriteLine("Textiles are empty.");
}
else if (medicaments.Count == 0)
{
    Console.WriteLine("Medicaments are empty.");
}

if (craftedItems.Count != 0)
{
    var items = from pair in craftedItems
                orderby pair.Value descending,
                        pair.Key
                select pair;
    foreach (var item in items)
    {
        Console.WriteLine($"{item.Key} - {item.Value}");
    }
}

if (textiles.Count > 0)
{
    Console.WriteLine($"Textiles left: {string.Join(", ",textiles)}");
}
else if(medicaments.Count > 0)
{
    Console.WriteLine($"Medicaments left: {string.Join(", ", medicaments)}");
}