using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Box_of_String
{
    public class Box<T>
    {
        private List<T> items { get; set; }

        public Box()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder= new StringBuilder();

            foreach (T item in items)
            {
                stringBuilder.AppendLine($"{item.GetType()}: {item}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
