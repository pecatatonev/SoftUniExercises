int[] foodPortions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int[] stamina = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();


Stack<int> stackFood = new Stack<int>();
Queue<int> queueStamina = new Queue<int>();
for (int i = 0; i < foodPortions.Length; i++)
{
	stackFood.Push(foodPortions[i]);
	queueStamina.Enqueue(stamina[i]);
}
//for (int i = 0; i < length; i++)
//{
//if isnt 100/100 try diff stamina and food
//}


Queue<string> mountainsPeaks = new Queue<string>();
Queue<int> mountainsPeaksLevel = new Queue<int>();
mountainsPeaks.Enqueue("Vihren");
mountainsPeaks.Enqueue("Kutelo");
mountainsPeaks.Enqueue("Banski Suhodol");
mountainsPeaks.Enqueue("Polezhan");
mountainsPeaks.Enqueue("Kamenitza");

mountainsPeaksLevel.Enqueue(80);
mountainsPeaksLevel.Enqueue(90);
mountainsPeaksLevel.Enqueue(100);
mountainsPeaksLevel.Enqueue(60);
mountainsPeaksLevel.Enqueue(70);


List<string> conqueredPeaks = new List<string>();
for (int i = 0; i < 7; i++)
{
	if (stackFood.Peek() + queueStamina.Peek() >= mountainsPeaksLevel.Peek())
	{
		stackFood.Pop();
		queueStamina.Dequeue();
		mountainsPeaksLevel.Dequeue();
		conqueredPeaks.Add(mountainsPeaks.Dequeue());

    }
	else if (stackFood.Peek() + queueStamina.Peek() < mountainsPeaksLevel.Peek())
	{
        stackFood.Pop();
        queueStamina.Dequeue();
    }

	if (mountainsPeaks.Count == 0)
	{
		Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
		break;
	}
	
}

 if (mountainsPeaks.Count > 0)
{
    Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
}

if (conqueredPeaks.Count == 0)
{
	return;
}
Console.WriteLine($"Conquered peaks:{Environment.NewLine}" +
	$"{string.Join(Environment.NewLine,conqueredPeaks)}");