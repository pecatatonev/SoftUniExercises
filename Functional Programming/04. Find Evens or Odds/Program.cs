int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

string command = Console.ReadLine();

Predicate<int> predicate = EvenOrOdd;

for (int i = numbers[0]; i <= numbers[1]; i++)
{
	if (predicate(i) == true && command == "even")
	{ 
		Console.Write(i + " ");
	}
	if(predicate(i) == false && command == "odd")
	{
		Console.Write(i + " ");
	}
	
}

bool EvenOrOdd(int num)
{
	//even chetno
	if (num % 2 == 0)
	{
        return true;
    }
   return false;
}