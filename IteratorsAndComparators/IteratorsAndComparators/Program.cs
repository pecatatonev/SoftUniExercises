using IteratorsAndComparators;

List<string> createCommand = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Skip(1)
    .ToList();

ListyIterator<string> listy = new(createCommand);

string command = string.Empty;
while ((command = Console.ReadLine()) != "END")
{
    switch (command)
    {
        case "Move":
            Console.WriteLine(listy.Move());
            break;
        case "HasNext":
            Console.WriteLine(listy.HasNext());
            break;
        case "Print":
            try
            {
                listy.Print();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
           
            break;
    }
}