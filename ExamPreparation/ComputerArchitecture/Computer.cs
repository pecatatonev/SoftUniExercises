using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ComputerArchitecture
{
    public class Computer
    {
        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
            Multiprocessor = new List<CPU>();
        }

        public int Count { get { return Multiprocessor.Count; } }//add 1 for every proccesor i add
        public string Model { get; set; }
        public int Capacity { get; set; }
        public List<CPU> Multiprocessor { get; set; }

        public void Add(CPU cpu) 
        {
            if (Multiprocessor.Count < Capacity)
            {
                this.Multiprocessor.Add(cpu);
                
            }
        }

        public bool Remove(string brand)
        {
            //CPU cpuToRemove = Multiprocessor.FirstOrDefault(x => x.Brand == brand);
            //if (cpuToRemove != null)
            //{
            //    return Multiprocessor.Remove(cpuToRemove);
            //}

            //return false;
           
            for (int i = 0; i < Multiprocessor.Count; i++)
            {
                if (Multiprocessor[i].Brand == brand)
                {
                    Multiprocessor.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        public CPU MostPowerful() 
        {
            //double mostPower = Multiprocessor.Max(b => b.Frequency);
            //foreach (var item in Multiprocessor)
            //{
            //    if (item.Frequency == mostPower)
            //    {
            //        return item;
            //    }
            //}
            //return Multiprocessor.Max();

            if (Multiprocessor.Count == 0)
            {
                return null;
            }
            CPU mostPowerful = Multiprocessor[0];

            foreach (var item in Multiprocessor)
            {
                if (item.Frequency > mostPowerful.Frequency)
                {
                    mostPowerful = item;
                }
            }
            return mostPowerful;
        }

        public CPU GetCPU(string brand)
        {
            foreach (var cpu in Multiprocessor)
            {
                if (cpu.Brand == brand)
                {
                    return cpu;
                }
                
            }

            return null;
        }

        public string Report() 
        {
            return $"CPUs in the Computer {Model}:{Environment.NewLine}" +
                $"{string.Join(Environment.NewLine,Multiprocessor)}";
        }
    }
}
