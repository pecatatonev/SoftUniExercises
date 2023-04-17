using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WidlFarm.Models.Foods;

namespace WidlFarm.Models.Animals
{
    public class Cat : Feline
    {
        private const double CatWeightMultiplier = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightMultiplier
            => CatWeightMultiplier;

        public override IReadOnlyCollection<Type> PrefferedFoods
            => new HashSet<Type> { typeof(Vegetable), typeof(Meat) };

        public override string ProduceSound() => "Meow";
    }
}
