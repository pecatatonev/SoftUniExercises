﻿using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Druid : BaseHero, IBaseHero
    {
        private const int DefaultPower = 80;
        public Druid(string name) : base(name,DefaultPower)
        {    
        }

        public override string CastAbility() => $"{this.GetType().Name} - {Name} healed for {Power}";
    }
}
