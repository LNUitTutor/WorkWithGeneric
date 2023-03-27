using System;

namespace WorkWithGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Banyak b1 = new Banyak(5.0, 10.0);
			Banyak b2 = new Banyak(6.0, 9.0);
			Banyak b3 = new Banyak(4.0, 11.0);
			Banyak b4 = new Banyak(7.0, 12.0);
			Banyak b5 = new Banyak(7.0, 12.0);
			Banyak.printAll();
            double sum = Banyak.getSumVolume();
            Console.WriteLine("Сумарний об'єм: " + sum+ " мл");
            ShapeWithVolume maximal = Banyak.getMaxVolume();
            Console.WriteLine(maximal);
            Console.WriteLine($"Баняк з максимальним об'ємом: {maximal}");

        }
	}
}
