using System;
using System.Collections.Generic;

namespace WorkWithGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapePart(); Console.ReadLine();
            DevicePart(); Console.ReadLine();
            PondPart(); Console.ReadLine();
        }

        private static void DevicePart()
        {
            Console.WriteLine("*** DevicePart ------------------------------------\n");
            FlashMemory[] F = { new FlashMemory(), new FlashMemory("Kingston", 64), new FlashMemory("Toshiba", 128) };
            Console.WriteLine($" Mem = {Algorithms.TotalVolume(F)} Gb\n");

            Algorithms.PrintAll(F); Console.WriteLine();

            Algorithms.DoWithEachl(F, f => Console.WriteLine(f));
            Console.WriteLine($"\n Mem = {Algorithms.Accumulate(F, (IVolumable f, double r) => r += f.Volume())} Gb\n");

            HardDrive[] HDD = { new HardDrive(HardDrive.ConsumerSegment.Desktop, 512, 355.5),
                new HardDrive(HardDrive.ConsumerSegment.External, 256, 128.75),
                new HardDrive(HardDrive.ConsumerSegment.Mobile, 1024, 517) };
            Console.WriteLine($" Total HDD before formatting = {Algorithms.TotalVolume(HDD)} Gb\n");
            Algorithms.DoWithEachl(HDD, h => h.format());
            Console.WriteLine($" Total HDD after formatting = {Algorithms.TotalVolume(HDD)} Gb\n");

            List<IVolumable> devices = new List<IVolumable>();
            devices.AddRange(F); devices.AddRange(HDD);
            Console.WriteLine(" Total memory of all devises = {0} Gb\n",
                Algorithms.Accumulate<IVolumable, double>(devices, (f,  r) => r += f.Volume()));
        }

        private static void ShapePart()
        {
            Console.WriteLine("*** ShapePart -------------------------------------\n");
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
            Console.WriteLine($" Pum = {Algorithms.TotalVolume(P)}");

            List<Cylinder> C = new List<Cylinder>();
            for (int i = 0; i < arr.Length; ++i)
                if (arr[i] is Cylinder) C.Add(arr[i] as Cylinder);
            Console.WriteLine($" Cum = {Algorithms.TotalVolume(C.ToArray())}");
            Algorithms.PrintAll(arr); Console.WriteLine();

        }

        private static void PondPart()
        {
            Console.WriteLine("*** PondPart ------------------------------------\n");
            Pond[] F = { new Pond("Dnipro Reservoir", 8, 129000, 7000), new Pond("Busk Lyman", 5.2, 82000, 11000), new Pond("Desna", 3, 100300, 150) };
            Console.WriteLine($" Water Volume = {Algorithms.TotalVolume(F)} cubic meters\n");
            Console.WriteLine($"\n Water Volume = {Algorithms.Accumulate(F, (IVolumable f, double r) => r += f.Volume())} cubic meters\n");

            Algorithms.PrintAll(F); Console.WriteLine();

            Algorithms.DoWithEachl(F, f => { f.AverageDepth *= 0.9; });
            Algorithms.PrintAll(F); Console.WriteLine();

            Console.WriteLine($" Water Volume = {Algorithms.TotalVolume(F)} cubic meters\n");
            Console.WriteLine($"\n Water Volume = {Algorithms.Accumulate(F, (IVolumable f, double r) => r += f.Volume())} cubic meters\n");
        }
    }
}
