using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WidlFarm.Models.Animals;
using WidlFarm.Models.Interfaces;
using WildFarm.Factories.Interfaces;

namespace WildFarm.Factories
{
    public class AnimalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal(string[] animaltokens)
        {
            string type = animaltokens[0];
            string name = animaltokens[1];
            double weight = double.Parse(animaltokens[2]);

            switch (type)
            {
                case "Owl":
                    return new Owl(name, weight, double.Parse(animaltokens[3]));
                case "Hen":
                    return new Hen(name, weight, double.Parse(animaltokens[3]));
                case "Mouse":
                    return new Mouse(name, weight, animaltokens[3]);
                case "Dog":
                    return new Dog(name, weight, animaltokens[3]);
                case "Cat":
                    return new Cat(name, weight, animaltokens[3], animaltokens[4]);
                case "Tiger":
                    return new Tiger(name, weight, animaltokens[3], animaltokens[4]);
                default:
                    throw new ArgumentException("Invalid animal type");
            }
        }
    }
}
