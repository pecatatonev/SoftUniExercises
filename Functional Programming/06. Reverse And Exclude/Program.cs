int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

List<int> result = new List<int>();
int div = int.Parse(Console.ReadLine());
Func<int,int,bool> isDivisible = IsDivisible;

for (int i = numbers.Length - 1; i >=0; i--)
{
    if (isDivisible(numbers[i],div))
    {
        continue;
    }
    result.Add(numbers[i]);
}

Console.WriteLine(String.Join(" ",result));
bool IsDivisible(int num,int div)
{
    if (num % div == 0)
    return true;
    else
    {
        return false;
    }
}