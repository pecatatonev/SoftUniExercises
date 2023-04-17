using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WidlFarm.Models.Foods;

namespace WidlFarm.Models.Animals
{
    public class Tiger : Feline
    {
        private const double TigerWeightMultiplier = 1.00;
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightMultiplier => TigerWeightMultiplier;

        public override IReadOnlyCollection<Type> PrefferedFoods
            => new HashSet<Type> { typeof(Meat) };

        public override string ProduceSound() => "ROAR!!!";
    }
}
