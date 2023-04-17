int n = int.Parse(Console.ReadLine());

int[] dividers = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Func<int, int, bool> isDivisible = IsDivisible;
for (int i = 1; i <= n; i++)
{
    bool allCorrect = true;
    for (int j = 0; j < dividers.Length; j++)
    {
        
        if (isDivisible(i, dividers[j]) == false)
        {
            allCorrect= false;
        }
    }
    if (allCorrect == true)
    {
        Console.Write(i + " ");
    }
}

bool IsDivisible(int num,int divider) 
{
    if (num % divider == 0)
    {
        return true;
    }
    return false;
}