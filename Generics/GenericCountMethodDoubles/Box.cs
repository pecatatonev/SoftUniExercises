using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Count_Method_Strings
{
    internal class Box<T> where T : IComparable<T>
    {
        private List<T> items;
        public Box()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public int CompareCount(T elementToCompare)
        {
            int count = 0;
            foreach (var item in items)
            {
                if (item.CompareTo(elementToCompare) > 0)
                {
                    count++;
                }
            }

            return count;
        }

    }
}
