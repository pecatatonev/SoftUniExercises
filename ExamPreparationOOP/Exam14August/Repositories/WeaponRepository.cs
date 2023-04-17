﻿using PlanetWars.Models.Weapons;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetWars.Repositories
{
    public class WeaponRepository : IRepository<IWeapon>
    {
        public WeaponRepository()
        {
            weapons = new List<IWeapon> { };
        }
        private List<IWeapon> weapons;
        public IReadOnlyCollection<IWeapon> Models => this.weapons;

        public void AddItem(IWeapon model)
        {
            weapons.Add(model);
        }

        public IWeapon FindByName(string name)
        {
            return weapons.FirstOrDefault(p => p.GetType().Name == name);
        }

        public bool RemoveItem(string name)
        {
            return weapons.Remove(weapons.FirstOrDefault(p => p.GetType().Name == name));
        }
    }
}
