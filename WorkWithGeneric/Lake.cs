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

        public Lake(string n, double vol, double ar)
        {
            volume = vol; area = ar; name = n;
        }

        public Lake() : this(string.Empty, 1, 1) { }
       
        // ToString()
        public override string ToString()
        {
            return $"Lake:\n\tName: {name};\n\tArea of lake: {area};\n\tVolume: {volume};";
        }
    }
}
