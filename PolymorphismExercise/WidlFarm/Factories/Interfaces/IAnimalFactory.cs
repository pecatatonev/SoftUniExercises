using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WidlFarm.Models.Interfaces;

namespace WildFarm.Factories.Interfaces
{
    public interface IAnimalFactory
    {
        IAnimal CreateAnimal(string[] animaltokens);
    }
}
