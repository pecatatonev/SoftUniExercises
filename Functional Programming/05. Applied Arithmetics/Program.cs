int[] numbers = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string command = string.Empty;

Func<int[], int[]> add = Add;
Func<int[], int[]> multiply = Multiply;
Func<int[], int[]> substract = Substract;


while ((command = Console.ReadLine()) != "end")
{
    if (command == "add")
    {
        add(numbers);
    }
    else if (command == "multiply")
    {
        multiply(numbers);
    }
    else if (command == "subtract")
    {
        substract(numbers);
    }
    else if (command == "print")
    {
        Console.WriteLine(String.Join(" ", numbers));
    }
    else if (command == "end") break;
}

int[] Add(int[] number)
{

    for (int i = 0; i < number.Length; i++)
    {
        number[i]++;
    }
    return number;
}
int[] Multiply(int[] number)
{

    for (int i = 0; i < number.Length; i++)
    {
        number[i] *= 2;
    }
    return number;
}
int[] Substract(int[] number)
{

    for (int i = 0; i < number.Length; i++)
    {
        number[i]--;
    }
    return number;
}