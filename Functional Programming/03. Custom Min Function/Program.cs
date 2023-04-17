int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

Func<int,int, int> numberOnConsole = SmallestNumber;

int smallestNumber = int.MaxValue ;
foreach (var num in numbers)
{
    smallestNumber = numberOnConsole(num,smallestNumber);
}

Console.WriteLine(smallestNumber);
int SmallestNumber(int number,int smallestNumber) 
{

    if (smallestNumber > number)
    {
        smallestNumber = number;
    }

    return smallestNumber;
}