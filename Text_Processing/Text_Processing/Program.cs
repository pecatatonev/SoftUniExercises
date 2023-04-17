using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Text_Processing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ")
                .ToArray();

            foreach (string currName in usernames)
            {
                if (currName.Length >= 3 && currName.Length <= 16)
                {
                    bool isUsernameValid = true;

                    foreach (char currCh in currName)
                    {
                        if (!(char.IsLetterOrDigit(currCh) || currCh == '-' || currCh == '_'))
                        {
                            isUsernameValid = false;
                            break;
                        }
                    }

                    if (isUsernameValid == true)
                    {
                        Console.WriteLine(currName);
                    }
                }
            }
        }
    }
}
