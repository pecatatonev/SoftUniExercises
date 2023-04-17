int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int row = nums[0];
int col = nums[1];

char[,] playground = new char[row, col];
int startingPosionRow = 0;
int startingPosionCol = 0;
int playersTouched = 0;
int countMoves = 0;
for (int i = 0; i < row; i++)
{
	char[] chars = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    for (int j = 0; j < col; j++)
    {
        playground[i,j] = chars[j];
            if (chars[j] == 'B')
            {
                startingPosionRow = i;
                startingPosionCol = j;
            }
    }
}
string command = string.Empty;
while ((command = Console.ReadLine()) != "Finish")
{
    if (playersTouched == 3)
    {
        break;
    }
    switch (command)
    {
        case "up":
            startingPosionRow--;
            if (startingPosionRow < 0 || startingPosionRow >= row)
            {
                startingPosionRow++;
                continue;
            }
            if (playground[startingPosionRow, startingPosionCol] == 'O')
            {
                startingPosionRow++;
                continue;
            }
            if (playground[startingPosionRow,startingPosionCol] == 'P')
            {
                playersTouched++;
                playground[startingPosionRow,startingPosionCol] = '-';
            }
            countMoves++;
            break;
        case "down":
            startingPosionRow++;
            if (startingPosionRow < 0 || startingPosionRow >= row)
            {
                startingPosionRow--;
                continue;
            }
            if (playground[startingPosionRow, startingPosionCol] == 'O')
            {
                startingPosionRow--;
                continue;
            }
            if (playground[startingPosionRow, startingPosionCol] == 'P')
            {
                playersTouched++;
                playground[startingPosionRow, startingPosionCol] = '-';
            }
            countMoves++;
            break;
        case "right":
            startingPosionCol++;
            if (startingPosionCol < 0 || startingPosionCol >= row)
            {
                startingPosionCol--;
                continue;
            }
            if (playground[startingPosionRow, startingPosionCol] == 'O')
            {
                startingPosionCol--;
                continue;
            }
            if (playground[startingPosionRow, startingPosionCol] == 'P')
            {
                playersTouched++;
                playground[startingPosionRow, startingPosionCol] = '-';
            }
            countMoves++;
            break;
        case "left":
            startingPosionCol--;
            if (startingPosionCol < 0 || startingPosionCol >= row)
            {
                startingPosionCol++;
                continue;
            }
            if (playground[startingPosionRow,startingPosionCol] == 'O')
            {
                startingPosionCol++;
                continue;
            }
            if (playground[startingPosionRow, startingPosionCol] == 'P')
            {
                playersTouched++;
                playground[startingPosionRow, startingPosionCol] = '-';
            }
            countMoves++;
            break;
    }
}

Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {playersTouched} Moves made: {countMoves}");

//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < col; j++)
//    {
//        Console.Write(playground[i, j] + " ");
//    }
//    Console.WriteLine();//new line at each row  
//}
