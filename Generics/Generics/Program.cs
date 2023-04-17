List<int> numbers = new List<int> { 1, 2, 3 };

List<long> longNumbers = new List<long> { 1, 2, 3, 4 };

List<string> words = new List<string> {"edno", "dve", "tri" };

PrintList(numbers);
PrintList(longNumbers);
PrintList(words);
void PrintList<T>(List<T> list)
{
	foreach (var item in list)
	{
		Console.WriteLine($"With generics printing: {item}");
	}
}