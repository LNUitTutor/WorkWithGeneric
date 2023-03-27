using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithGeneric
{
    public static class Algorithms
    {
        public static double TotalVolume<T>(IEnumerable<T> objects) where T : IVolumable
        {
            double Sum = 0.0;
            foreach(T obj in objects) Sum += obj.Volume();
            return Sum;
        }
    }
}
