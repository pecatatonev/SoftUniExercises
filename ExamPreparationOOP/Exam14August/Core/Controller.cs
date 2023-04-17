using PlanetWars.Core.Contracts;
using PlanetWars.Models.MilitaryUnits;
using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Models.Planets;
using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Models.Weapons;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories;
using PlanetWars.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace PlanetWars.Core
{
    public class Controller : IController
    {
        private PlanetRepository planets;

        public Controller()
        {
            planets = new PlanetRepository();
        }
        public string CreatePlanet(string name, double budget)
        {
            if (planets.FindByName(name) != null)
            {
                return String.Format(OutputMessages.ExistingPlanet, name);
            }

            IPlanet planet = new Planet(name,budget);
            planets.AddItem(planet);

            return String.Format(OutputMessages.NewPlanet, name);
            
        }
        public string AddUnit(string unitTypeName, string planetName)
        {
            IPlanet planet = planets.FindByName(planetName);
            if (planet == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.UnexistingPlanet , planetName));
            }

            if (unitTypeName != "StormTroopers" && unitTypeName != "SpaceForces" && unitTypeName != "AnonymousImpactUnit")
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.ItemNotAvailable, unitTypeName));
            }

            if (planet.Army.FirstOrDefault(a => a.GetType().Name == unitTypeName) != null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.UnitAlreadyAdded, unitTypeName,planetName));
            }

            IMilitaryUnit unit;
            if (unitTypeName == "StormTroopers")
            {
                unit = new StormTroopers();
                planet.Spend(unit.Cost);
                planet.AddUnit(unit);
            }
            else if (unitTypeName == "SpaceForces")
            {
                unit = new SpaceForces();
                planet.Spend(unit.Cost);
                planet.AddUnit(unit);
            }
            else if (unitTypeName == "AnonymousImpactUnit")
            {
                unit = new AnonymousImpactUnit();
                planet.Spend(unit.Cost);
                planet.AddUnit(unit);
            }
            
            
            return String.Format(OutputMessages.UnitAdded,unitTypeName,planetName);
        }

        public string AddWeapon(string planetName, string weaponTypeName, int destructionLevel)
        {
            IPlanet planet = planets.FindByName(planetName);
            if (planet == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.UnexistingPlanet, planetName));
            }

            if (weaponTypeName != "BioChemicalWeapon" && weaponTypeName != "NuclearWeapon" && weaponTypeName != "SpaceMissiles")
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.ItemNotAvailable, weaponTypeName));
            }

            if (planet.Weapons.FirstOrDefault(a => a.GetType().Name == weaponTypeName) != null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.WeaponAlreadyAdded, weaponTypeName,planetName));
            }

            IWeapon weapon;
            if (weaponTypeName == "BioChemicalWeapon")
            {
                weapon = new BioChemicalWeapon(destructionLevel);
                planet.Spend(weapon.Price);
                planet.AddWeapon(weapon);
            }
            else if (weaponTypeName == "NuclearWeapon")
            {
                weapon = new NuclearWeapon(destructionLevel);
                planet.Spend(weapon.Price);
                planet.AddWeapon(weapon);
            }
            else if (weaponTypeName == "SpaceMissiles")
            {
                weapon = new SpaceMissiles(destructionLevel);
                planet.Spend(weapon.Price);
                planet.AddWeapon(weapon);
            }
            

            return String.Format(OutputMessages.WeaponAdded, planetName, weaponTypeName);
        }

        public string SpecializeForces(string planetName)
        {
            IPlanet planet = planets.FindByName(planetName);
            if (planet == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.UnexistingPlanet, planetName));
            }

            if (planet.Army.Count == 0)
            {
                throw new InvalidOperationException(ExceptionMessages.NoUnitsFound);
            }

            planet.Spend(1.25);
            planet.TrainArmy();

            return String.Format(OutputMessages.ForcesUpgraded,planetName);
        }
        public string SpaceCombat(string planetOne, string planetTwo)
        {
            IPlanet planet1 = planets.FindByName(planetOne);
            IPlanet planetNew = new Planet(planet1.Name, planet1.Budget);
            IPlanet planet2 = planets.FindByName(planetTwo);
            IPlanet planetNew2 = new Planet(planet2.Name, planet2.Budget);

            IWeapon weaponPlanet1 = planet1.Weapons.FirstOrDefault(w => w.GetType().Name == "NuclearWeapon");
            IWeapon weaponPlanet2 = planet2.Weapons.FirstOrDefault(w => w.GetType().Name == "NuclearWeapon");
            if (planetNew.MilitaryPower == planetNew2.MilitaryPower)
            {

                if (weaponPlanet1 != null && weaponPlanet2 != null)
                {
                    // both have nuclear weapon and lose half of their budget
                    return DrawInWars(planet1, planet2);
                }
                else if (weaponPlanet1 == null && weaponPlanet2 == null)
                {
                    // both dont have nuclear weapon and lose half of their budget
                    return DrawInWars(planet1, planet2);
                }

                if (weaponPlanet1 != null)
                {
                    // planet 1 wins
                    double lostBudget = planet1.Budget / 2;
                    planet1.Spend(lostBudget);
                    double lostBudgetOnLosingPlanet = planet2.Budget / 2;
                    planet1.Profit(lostBudgetOnLosingPlanet);
                    double sum = planet2.Army.Sum(p => p.Cost) + planet2.Weapons.Sum(w => w.Price);
                    planet1.Profit(sum);
                    planets.RemoveItem(planet2.Name);
                    return String.Format(OutputMessages.WinnigTheWar, planetOne);

                }
                else if (weaponPlanet2 != null)
                {
                    //planet 2 wins
                    double lostBudget = planet2.Budget / 2;
                    planet2.Spend(lostBudget);
                    double lostBudgetOnLosingPlanet = planet1.Budget / 2;
                    planet2.Profit(lostBudgetOnLosingPlanet);
                    double sum = planet1.Army.Sum(p => p.Cost) + planet1.Weapons.Sum(w => w.Price);
                    planet2.Profit(sum);
                    planets.RemoveItem(planet1.Name);
                    return String.Format(OutputMessages.WinnigTheWar, planetTwo);
                }
            }

            if (planetNew.MilitaryPower > planetNew2.MilitaryPower)
            {
                // planet 1 wins
                double lostBudget = planet1.Budget / 2;
                planet1.Spend(lostBudget);
                double lostBudgetOnLosingPlanet = planet2.Budget / 2;
                planet1.Profit(lostBudgetOnLosingPlanet);
                double sum = planet2.Army.Sum(p => p.Cost) + planet2.Weapons.Sum(w => w.Price);
                planet1.Profit(sum);
                planets.RemoveItem(planet2.Name);
                return String.Format(OutputMessages.WinnigTheWar, planetOne);
            }
            else if (planetNew.MilitaryPower < planetNew2.MilitaryPower)
            { 
            //planet 2 wins
            double lostBudget = planet2.Budget / 2;
            planet2.Spend(lostBudget);
            double lostBudgetOnLosingPlanet = planet1.Budget / 2;
            planet2.Profit(lostBudgetOnLosingPlanet);
            double sum = planet1.Army.Sum(p => p.Cost) + planet1.Weapons.Sum(w => w.Price);
            planet2.Profit(sum);
            planets.RemoveItem(planet1.Name);
            return String.Format(OutputMessages.WinnigTheWar, planetTwo);
            }
            return null;
        }

        private static string DrawInWars(IPlanet planet1, IPlanet planet2)
        {
            double lostBudget = planet1.Budget / 2;
            planet1.Spend(lostBudget);
            double lostBudget2 = planet2.Budget / 2;
            planet2.Spend(lostBudget2);
            return String.Format(OutputMessages.NoWinner);
        }

        public string ForcesReport()
        {
            planets.Models
                .OrderByDescending(m => m.MilitaryPower).OrderBy(x =>x.Name);

            StringBuilder sb = new StringBuilder();
            foreach (var planet in planets.Models)
            {
                sb.AppendLine(planet.PlanetInfo());
            }

            return sb.ToString().Trim();
        }


    }
}
