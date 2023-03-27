using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithGeneric
{
    public static class Algorithms
    {
        public static double TotalVolume<T>(T[] objects)
        {
            double Sum = 0.0;
            for (int i = 0; i < objects.Length; ++i) Sum += (objects[i] as Shape3D).Volume();
            return Sum;
        }
    }
}
