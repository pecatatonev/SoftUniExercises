int n = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine().Split(" ").ToArray();

Func<int, int, bool> isNameValid = IsNameValid;

foreach (var name in names)
{
	if (isNameValid(n, name.Length))
	{
		Console.WriteLine(name);
	}
}
bool IsNameValid(int num,int lenght)
{
	if (num < lenght)
	{
		return false;
	}
	return true;
}