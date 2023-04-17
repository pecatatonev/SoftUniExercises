string[] names = Console.ReadLine().Split(" ").ToArray();

Action<string> namesOnConsole = NamesOnConsole;

foreach (string name in names)
namesOnConsole(name);
void NamesOnConsole(string name)
{
	Console.WriteLine(name);
};
