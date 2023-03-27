using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithGeneric
{
    public class FlashMemory : IVolumable
    {
        string producer;
        int capacity;
        public FlashMemory(string prod = "Kingston", int cap = 16)
        {
            producer = prod; capacity = cap;
        }
        public string Producer
        {
            get => producer;
        }
        public int Capacity
        {
            get => capacity;
        }
        public override string ToString()
        {
            return $"Flas({producer},{capacity}Gb)";
        }
        public double Volume()
        {
            return this.Capacity;
        }
    }
}
