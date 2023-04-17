using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WidlFarm.Models.Foods;

namespace WidlFarm.Models.Animals
{
    public class Owl : Bird
    {
        private const double OwlWeightMultiplier = 0.25;
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override double WeightMultiplier => OwlWeightMultiplier;

        public override IReadOnlyCollection<Type> PrefferedFoods
            => new HashSet<Type> {typeof(Meat)};

        public override string ProduceSound() => $"Hoot Hoot";
    }
}
