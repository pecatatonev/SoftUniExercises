using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());
            string messages = string.Empty;
            StringBuilder decryptedMessage = new StringBuilder();
            List<string> attackedPlanets = new List<string>();
            int countAttackedPlanets = 0;
            List<string> destroyedPlanets = new List<string>();
            int countDestroyedPlanets = 0;
            string pattern = @"[^\@\-\!\:\>]*?\@(?<planetName>[A-Z][a-z]+)[^\@\-\!\:\>]*?\:(?<population>\d*)[^\@\-\!\:\>]*?\!(?<attackType>[A-Z])\![^\@\-\!\:\>]*?\->(?<soldierCount>\d*)";
            var regex = new Regex(pattern);
            for (int i = 0; i < numberOfMessages; i++)
            {
                if (i > 0)
                {
                    
                    decryptedMessage.Clear();
                }
                int count = 0;
                messages= Console.ReadLine();
                for (int j = 0; j < messages.Length; j++)
                {
                    //check for how many letters are in a message
                    char letters = messages[j];

                    if (letters == 'S' || letters == 'T' || letters == 'A' || letters == 'R' ||
                        letters == 's' || letters == 't' || letters == 'a' || letters == 'r')
                    {
                        count++;
                    }
                    
                }
                

                for (int j = 0; j < messages.Length; j++)
                {
                    char lettres = messages[j];
                    int realLetter = lettres - count;
                    decryptedMessage.Append((char) realLetter);
                }

                //After Decryption
                var match = regex.Match(decryptedMessage.ToString());
                if (!match.Success) {
                    continue;
                }

                //every group params
                string planetName = match.Groups["planetName"].Value;
                int population = int.Parse(match.Groups["population"].Value);
                string attackType = match.Groups["attackType"].Value;
                int soldierCount = int.Parse(match.Groups["soldierCount"].Value);

                if (attackType == "A")
                {
                    attackedPlanets.Add(planetName);
                    countAttackedPlanets++;

                }
                else if (attackType == "D")
                {
                    destroyedPlanets.Add(planetName);
                    countDestroyedPlanets++;
                }
            }
            attackedPlanets.Sort();
            destroyedPlanets.Sort();
            Console.WriteLine($"Attacked planets: {countAttackedPlanets}");
            for (int i = 0; i < countAttackedPlanets; i++)
            {
                Console.WriteLine($"-> {attackedPlanets[i]}");
            }
            Console.WriteLine($"Destroyed planets: {countDestroyedPlanets}");
            for (int i = 0; i < countDestroyedPlanets; i++)
            {
                Console.WriteLine($"-> {destroyedPlanets[i]}");
            }

        }
    }
}
