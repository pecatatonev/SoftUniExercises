﻿using Generic_Box_of_String;

int n = int.Parse(Console.ReadLine());


Box<string> box = new Box<string>();
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    
    box.Add(input);
}

Console.WriteLine(box.ToString());