using System;
//TruePelmen Lake class

namespace WorkWithGeneric
{
    class Lake : IVolumable
    {
        //Fields
        private string name;
        private double volume;
        private double area;
        //Getters
        public double Area() { return area; }
        public string Name() { return name; }
        // Interface realization
        public double Volume() { return volume; }
        // Constructor
        public Lake(string n = "", double vol = 1, double ar = 1)
        {
            volume = vol; area = ar; name = n;
        }
       
       
        // ToString()
        public override string ToString()
        {
            return $"Lake:\n\tName: {name};\n\tArea of lake: {area};\n\tVolume: {volume};";
        }
    }
}
