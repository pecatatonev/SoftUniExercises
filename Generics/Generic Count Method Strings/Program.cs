using Generic_Count_Method_Strings;

int n = int.Parse(Console.ReadLine());

Box<string> box= new Box<string>();
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();

    box.Add(input);
}

string elementToCompare = Console.ReadLine();

Console.WriteLine(box.CompareCount(elementToCompare)); 