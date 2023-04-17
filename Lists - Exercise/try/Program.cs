using System;
using System.Collections.Generic;
using System.Linq;

namespace tryExercise
{
    class Program
{
    static void Main(string[] args)
    {
        List <string> array = Console.ReadLine()
            .Split("|")
            .ToList();

            array.Reverse();
            List<string> arrayNum = new List<string>();
            for (int i = 0; i < array.Count; i++)
            {
                string[] inputParams = array[i].Split();
                for (int j = 0; j < inputParams.Length; j++)
                {
                    if (inputParams[j] != "")
                    {
                        arrayNum.Add(inputParams[j]);
                    }
                    
                }
                
            }
            
            Console.WriteLine(string.Join(" ",arrayNum));
        }
}
}
