using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetWars.Repositories
{
    public class UnitRepository : IRepository<IMilitaryUnit>
    {
        public UnitRepository()
        {
            units = new List<IMilitaryUnit> { };
        }
        private List<IMilitaryUnit> units;
        public IReadOnlyCollection<IMilitaryUnit> Models => this.units;

        public void AddItem(IMilitaryUnit model)
        {
            units.Add(model);
        }

        public IMilitaryUnit FindByName(string name)
        {
            return units.FirstOrDefault(p => p.GetType().Name == name);
        }

        public bool RemoveItem(string name)
        {
            return units.Remove(units.FirstOrDefault(p => p.GetType().Name == name));
        }
    }
}
