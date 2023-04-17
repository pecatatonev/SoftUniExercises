using Generic_Count_Method_Strings;

int n = int.Parse(Console.ReadLine());

Box<double> box = new Box<double>();
for (int i = 0; i < n; i++)
{
    double input = double.Parse(Console.ReadLine());

    box.Add(input);
}

double elementToCompare = double.Parse(Console.ReadLine());

Console.WriteLine(box.CompareCount(elementToCompare));