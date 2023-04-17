using System;
using System.Linq;
using System.Collections.Generic;

namespace midexam
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int daysOfAdventure = int.Parse(Console.ReadLine());
			int numOfPlayers = int.Parse(Console.ReadLine());
			double energyOfGroup = double.Parse(Console.ReadLine());
			double waterPerDayFSP = double.Parse(Console.ReadLine());
			double foodPerDayFSP = double.Parse(Console.ReadLine());

			double waterOfGroup = waterPerDayFSP * numOfPlayers * daysOfAdventure;
			double foodOfGroup = foodPerDayFSP * numOfPlayers * daysOfAdventure;

			for (int i = 1; i <= daysOfAdventure; i++)
			{
				double dailyEnergyLoss = double.Parse(Console.ReadLine());
				energyOfGroup -= dailyEnergyLoss;
				if (i % 2 == 0)
				{
					energyOfGroup += (energyOfGroup * 0.05);
					waterOfGroup -= (waterOfGroup * 0.3);
				}
				if (i % 3 == 0)
				{
					energyOfGroup += (energyOfGroup * 0.1);
					foodOfGroup -= (foodOfGroup / numOfPlayers);
				}
				if (energyOfGroup <= 0)
				{
					break;
				}
			}
			if (energyOfGroup > 0)
			{
				Console.WriteLine($"You are ready for the quest. You will be left with - {energyOfGroup:f2} energy!");
			}
			else
			{
				Console.WriteLine($"You will run out of energy. You will be left with {foodOfGroup:f2} food and {waterOfGroup:f2} water.");

			}
		}
	}
}