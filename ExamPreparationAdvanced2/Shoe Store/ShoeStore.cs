using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace ShoeStore
{
    public class ShoeStore
    {
        public ShoeStore(string name, int storageCapacity)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            Shoes = new List<Shoe>();
        }

        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        public List<Shoe> Shoes { get; set; }

        public int Count { get { return Shoes.Count; } }

        public string AddShoe(Shoe shoe)
        {
            if (Shoes.Count < StorageCapacity)
            {
                Shoes.Add(shoe);
                return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
            }

            return "No more space in the storage room.";
        }

        public int RemoveShoes(string material)
        {
            int count = 0;
            
            foreach (var item in Shoes.ToList())
            {
                if (item.Material == material)
                {
                    Shoes.Remove(item);
                    count++;
                }
            }

            return count;
        }

        public List<Shoe> GetShoesByType(string type)
        {
            List<Shoe> typeList = new List<Shoe>();
            string toLower = type.ToLower();
            foreach (var item in Shoes)
            {
                if (item.Type == toLower)
                {
                    typeList.Add(item);
                }
            }

            return typeList;
        }

        public Shoe GetShoeBySize(double size)
        {
            return Shoes.FirstOrDefault(sh => sh.Size == size);
        }

        public string StockList(double size, string type)
        {
            List<Shoe> neededShoe = new List<Shoe>();
            foreach (var item in Shoes)
            {
                if (item.Size == size && item.Type == type)
                {
                    neededShoe.Add(item);
                }
            }

            if (neededShoe.Count != 0)
            {
                return $"Stock list for size {size} - {type} shoes:{Environment.NewLine}" +
                    $"{string.Join(Environment.NewLine, neededShoe)}";
            }

            return "No matches found!";
        }
    }
}
