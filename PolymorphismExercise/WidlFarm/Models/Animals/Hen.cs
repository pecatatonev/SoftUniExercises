using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WidlFarm.Models.Foods;

namespace WidlFarm.Models.Animals
{
    public class Hen : Bird
    {
        private const double HenWeightMultiplier = 0.35;
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override double WeightMultiplier
            => HenWeightMultiplier;

        public override IReadOnlyCollection<Type> PrefferedFoods
            => new HashSet<Type> {typeof(Meat), typeof(Fruit), typeof(Seeds), typeof(Vegetable) };

        public override string ProduceSound() => "Cluck";
    }
}
