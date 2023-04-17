using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WidlFarm.Models.Foods;

namespace WidlFarm.Models.Animals
{
    public class Mouse : Mammal
    {
        private const double MouseWeightMultiplier = 0.10;
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override double WeightMultiplier
            => MouseWeightMultiplier;

        public override IReadOnlyCollection<Type> PrefferedFoods
            => new HashSet<Type> { typeof(Vegetable), typeof(Fruit) };
        public override string ProduceSound() => "Squeak";

        public override string ToString()
            => base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
    }
}
