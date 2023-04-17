using Generic_Box_of_String;

int n = int.Parse(Console.ReadLine());

Box<string> box= new Box<string>();
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();

    box.Add(input);
}

int[] ints = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

box.Swap(ints[0], ints[1]);

Console.WriteLine(box.ToString());