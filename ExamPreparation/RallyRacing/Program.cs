
int n = int.Parse(Console.ReadLine());

string racingNumber = Console.ReadLine();

char[,] raceRoute = new char[n,n];

int cordsForTunnel1 = 0;
int cordsForTunnel2 = 0;

int killometresPassed = 0;
for (int i = 0; i < n; i++)
{
    char[] chars = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(char.Parse)
            .ToArray();
    for (int j = 0; j < n; j++)
	{
		raceRoute[i,j] = chars[j];
        if (chars[j] == 'T')
        {
            cordsForTunnel1 = i; cordsForTunnel2 = j;
        }
	}
}
int cordsForCarRow = 0;
int cordsForCarCol = 0;
string command = string.Empty;
while ((command = Console.ReadLine()) != "End")
{
  
    switch (command)
    {
        case "left":
            cordsForCarCol -= 1;
            break;
        case "right":
            cordsForCarCol += 1;
            break;
        case "up":
            cordsForCarRow -= 1;
            break;
        case "down":
            cordsForCarRow += 1;
            break;
    }
    killometresPassed += 10;
    if (raceRoute[cordsForCarRow,cordsForCarCol] == 'T')
    {
        raceRoute[cordsForCarRow, cordsForCarCol] = '.';
        cordsForCarRow = cordsForTunnel1;
        cordsForCarCol = cordsForTunnel2;
        raceRoute[cordsForCarRow, cordsForCarCol] = '.';
        killometresPassed += 20;
    }

    if (raceRoute[cordsForCarRow,cordsForCarCol] == 'F')
    {
        raceRoute[cordsForCarRow, cordsForCarCol] = 'C';

        Console.WriteLine($"Racing car {racingNumber} finished the stage!");
        Console.WriteLine($"Distance covered {killometresPassed} km.");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(raceRoute[i, j]);
            }
            Console.WriteLine();//new line at each row
        }
        return;
    }
}
raceRoute[cordsForCarRow, cordsForCarCol] = 'C';
Console.WriteLine($"Racing car {racingNumber} DNF.");
Console.WriteLine($"Distance covered {killometresPassed} km.");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(raceRoute[i, j]);
    }
    Console.WriteLine();//new line at each row
}

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        Console.Write(raceRoute[i, j] + " ");
//    }
//    Console.WriteLine();//new line at each row
//}