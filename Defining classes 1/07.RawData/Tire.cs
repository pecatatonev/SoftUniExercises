using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Tire
    {
        public Tire(float tirePressure, int tireAge)
        {
            TirePressure = tirePressure;
            TireAge = tireAge;
        }

        public float TirePressure { get; set; }
        public int TireAge { get; set; }
    }
}
