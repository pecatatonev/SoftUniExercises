using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetWars.Models.MilitaryUnits
{
    public class MilitaryUnit : IMilitaryUnit
    {
        public MilitaryUnit(double cost)
        {
            Cost= cost;
            EnduranceLevel = 1;
        }
        private double cost;

        public double Cost
        {
            get { return cost; }
            private set { cost = value; }
        }
        // In QUID billions

        private int enduranceLevel;

        public int EnduranceLevel
        {
            get { return enduranceLevel; }
            private set { enduranceLevel = value; }
        }


        public void IncreaseEndurance()
        {
            EnduranceLevel += 1;
            if (EnduranceLevel > 20)
            {
                EnduranceLevel = 20;
                throw new ArgumentException(ExceptionMessages.EnduranceLevelExceeded);
            }
        }
    }
}
