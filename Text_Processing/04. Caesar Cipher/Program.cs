using System;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string encryptedText = string.Empty;
            foreach (var currCh in text)
            {
                int currPosition = currCh;
                currPosition += 3;
                encryptedText += (char)currPosition;
            }
            Console.WriteLine(encryptedText);
        }
    }
}
