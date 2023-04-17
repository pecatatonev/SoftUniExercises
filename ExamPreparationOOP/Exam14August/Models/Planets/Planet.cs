using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories;
using PlanetWars.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace PlanetWars.Models.Planets
{
    public class Planet : IPlanet
    {
        private List<IMilitaryUnit> units;
        private List<IWeapon> weapons;

        public Planet(string name, double budget)
        {
            Name= name;
            Budget= budget;
            units = new List<IMilitaryUnit>();
            weapons = new List<IWeapon>();
        }
        private string name;

        public string Name
        {
            get { return name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlanetName);
                }
                name = value; 
            }
        }


        private double budget;

        public double Budget
        {
            get { return budget; }
            private set
            {
                if (value < 0) 
                {
                    throw new ArgumentException(ExceptionMessages.InvalidBudgetAmount);
                }
                budget = value; 
            }
        }
        // in QUID billions

        private double militaryPower;

        public double MilitaryPower 
        {
            get { return militaryPower; }
            private set
            {
                value = CalculateMilitaryPower();
                Math.Round(value, 3);
                militaryPower = value;
            }
        }

        private double CalculateMilitaryPower()
        {
            double sum = units.Sum(u => u.EnduranceLevel) + weapons.Sum(w => w.DestructionLevel);
            if (units.FirstOrDefault(u => u.GetType().Name == "AnonymousImpactUnit") != null)
            {
                sum += sum * 0.3;
            }
            if (weapons.FirstOrDefault(u => u.GetType().Name == "NuclearWeapon") != null)
            {
                sum += sum * 0.45;
            }

            return sum;
        }

        public IReadOnlyCollection<IMilitaryUnit> Army => this.units;

        public IReadOnlyCollection<IWeapon> Weapons => this.weapons;

        public void AddUnit(IMilitaryUnit unit)
        {
            units.Add(unit);
        }

        public void AddWeapon(IWeapon weapon)
        {
            weapons.Add(weapon);
        }

        public void TrainArmy()
        {
            foreach (var unit in units)
            {
                unit.IncreaseEndurance();
            }
        }

        public void Spend(double amount)
        {
            if (Budget < amount)
            {
                throw new InvalidOperationException(ExceptionMessages.UnsufficientBudget);
            }
            Budget -= amount;
        }
        public void Profit(double amount)
        {
            Budget += amount;
        }

        public string PlanetInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Planet: {Name}");
            sb.AppendLine($"--Budget: {Budget} billion QUID");
            if (units.Count == 0)
            {
                sb.AppendLine($"--Forces: No units");
            }
            else
            {
                sb.AppendLine($"--Forces: {string.Join(units.GetType().Name, " ")} ");
            }
            if (weapons.Count == 0)
            {
                sb.AppendLine($"--Combat equipment: No weapons");
            }
            else
            {
                sb.AppendLine($"--Combat equipment: {string.Join(weapons.GetType().Name, " ")} ");
            }
            sb.AppendLine($"--Military Power: {MilitaryPower}");

            return sb.ToString().Trim();
        }

        
    }
}
