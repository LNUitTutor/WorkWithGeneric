using System;

namespace WorkWithGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape3D[] arr = { new Cylinder(), new Parallelepiped(), 
                new Parallelepiped(1, 2, 3), new Cylinder(3, 5) };
            for (int i = 0; i < arr.Length; ++i) Console.WriteLine(arr[i]);
            double sum = 0.0;
            for (int i = 0; i < arr.Length; ++i) sum += arr[i].Volume();
            Console.WriteLine($" sum = {sum}");
        }
    }
}
