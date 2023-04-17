using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public interface IBuyer
    {
        //void method for now
        int BuyFood(string name);
        int Food { get; }
    }
}
