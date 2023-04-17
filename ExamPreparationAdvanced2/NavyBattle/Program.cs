int n = int.Parse(Console.ReadLine());

char[,] battlefield = new char[n,n];

int cordsForSubmarineRow = 0;
int cordsForSubmarineCol = 0;

int countHitsByMine = 3;
int countBattleCruisers = 3;
for (int i = 0; i < n; i++)
{
    string inputBattlefield = Console.ReadLine();
    char[] chars = inputBattlefield.ToCharArray();
for (int j = 0; j < n; j++)
    {
        battlefield[i,j] = chars[j];
        if (battlefield[i,j] == 'S')
        {
            cordsForSubmarineRow = i;
            cordsForSubmarineCol = j;
                
        }
    }
}
battlefield[cordsForSubmarineRow, cordsForSubmarineCol] = '-';
string command = string.Empty;
while (countHitsByMine != 0 && countBattleCruisers !=0)
{
    
    command = Console.ReadLine();
    switch (command)
    {
        case "up":
            cordsForSubmarineRow--;
            break;
        case "down":
            cordsForSubmarineRow++;
            break;
        case "left":
            cordsForSubmarineCol--;
            break;
        case "right":
            cordsForSubmarineCol++;
            break;
    }

    if (battlefield[cordsForSubmarineRow,cordsForSubmarineCol] == '*')
    {
        battlefield[cordsForSubmarineRow, cordsForSubmarineCol] = '-';
        countHitsByMine--;

    }

    if (battlefield[cordsForSubmarineRow, cordsForSubmarineCol] == 'C')
    {
        battlefield[cordsForSubmarineRow, cordsForSubmarineCol] = '-';
        countBattleCruisers--;

    }
    
}

battlefield[cordsForSubmarineRow, cordsForSubmarineCol] = 'S';
if (countHitsByMine == 0)
{
    Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{cordsForSubmarineRow}, {cordsForSubmarineCol}]!");
}

if (countBattleCruisers == 0)
{
    Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
}


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(battlefield[i, j]);
    }
    Console.WriteLine();
}