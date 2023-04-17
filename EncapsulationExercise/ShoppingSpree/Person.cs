using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Person
    {
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bagOfProducts = new List<Product>();
        }
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be empty");
                }
                name = value;
            }
        }

        private decimal money;

        public decimal Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }
                money = value;
            }
        }

        private List<Product> bagOfProducts;

        public string Add(Product product) 
        {
            if (Money < product.Cost)
            {
                return $"{Name} can't afford {product}";
            }

            bagOfProducts.Add(product);

            Money-= product.Cost;

            return $"{Name} bought {product}";
        }
        public override string ToString()
        { 
        string productsToString = bagOfProducts.Any()
                ? string.Join(", ",bagOfProducts)
                : "Nothing bought";

            return $"{Name} - {productsToString}";
        }
    }
}
