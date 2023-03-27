using System;
using System.Collections.Generic;

namespace WorkWithGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape3D[] arr = { new Cylinder(), new Parallelepiped(), 
                new Parallelepiped(1, 2, 3), new Cylinder(3, 5), new Parallelepiped(4,4,1) };
            for (int i = 0; i < arr.Length; ++i) Console.WriteLine(arr[i]);
            double sum = 0.0;
            for (int i = 0; i < arr.Length; ++i) sum += arr[i].Volume();
            Console.WriteLine($" sum = {sum}");
            Console.WriteLine($" Sum = {Algorithms.TotalVolume(arr)}");
            List<Parallelepiped> P = new List<Parallelepiped>();
            for (int i = 0; i < arr.Length; ++i)
                if (arr[i] is Parallelepiped) P.Add(arr[i] as Parallelepiped);
            Console.WriteLine($" Pum = {Algorithms.TotalVolume(P.ToArray())}");

            List<Cylinder> C = new List<Cylinder>();
            for (int i = 0; i < arr.Length; ++i)
                if (arr[i] is Cylinder) C.Add(arr[i] as Cylinder);
            Console.WriteLine($" Cum = {Algorithms.TotalVolume(C.ToArray())}");

        }
    }
}
