using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> deckCard = Console.ReadLine()
                .Split(", ")
                .ToList();

            int n = int.Parse(Console.ReadLine());

            
            string command = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] inputParams = input.Split(", ");
                command = inputParams[0];


                if (command == "Add")
                {
                    if (deckCard.Contains(inputParams[1]))
                    {
                        Console.WriteLine("Card is already in the deck");
                        continue;
                    }
                    deckCard.Add(inputParams[1]);
                    Console.WriteLine("Card successfully added");
                }
                else if (command == "Remove")
                {
                    
                    if (deckCard.Contains(inputParams[1]))
                    {
                        
                        deckCard.Remove(inputParams[1]);
                        Console.WriteLine("Card successfully removed");
                        continue;
                    }

                    Console.WriteLine("Card not found");
                }
                else if (command == "Remove At")
                {
                    int index = int.Parse(inputParams[1]);
                    if (index < 0 || index > deckCard.Count)
                    {
                        Console.WriteLine("Index out of range");
                        continue;
                    }

                    deckCard.RemoveAt(index);
                    Console.WriteLine("Card successfully removed");
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(inputParams[1]);
                    string cardName = inputParams[2];

                    if (index < 0 || index > deckCard.Count)
                    {
                        Console.WriteLine("Index out of range");
                        continue;
                    }
                    else
                    {
                        if (deckCard.Contains(cardName))
                        {
                            Console.WriteLine("Card is already added");
                            continue;
                        }
                        
                    }

                    deckCard.Insert(index, cardName);
                    Console.WriteLine("Card successfully added");
                }
            }

            Console.WriteLine(string.Join(", ",deckCard));
        }
    }
}
