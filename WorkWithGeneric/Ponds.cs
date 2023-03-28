using System;

namespace WorkWithGeneric
{
    // водойма
    public class Pond: IVolumable
    {
        private const int MinDimentionVal = 2; 
        private double DepthMult;
        public string Name { get; set; }

        private double averageDepth;
        private int length;
        private int width;
        public double AverageDepth { 
            get { return averageDepth; } 
            set 
            { 
                averageDepth = (value > MinDimentionVal) ? value : MinDimentionVal; 
            } 
        }
        public double DeepestSpot { get { return AverageDepth * DepthMult; } }
        public int Length { 
            get { return length; }
            set 
            {
                length = (value > MinDimentionVal) ? value : MinDimentionVal;
            } 
        }
        public int Width 
        { 
            get { return width; }
            set 
            {
                width = (value > MinDimentionVal) ? value : MinDimentionVal;
            }
        }

        public Pond(string name, double AvDepth, int PLength, int PWidth)
        {
            Name = name;
            AverageDepth = AvDepth;
            Length = PLength;
            Width = PWidth;
            DepthMult = new Random().Next(100, 200)/100;
        }
        
        public double SurfaceArea()
        {
            return Width * Length;
        }

        public double Volume()
        {
            return SurfaceArea() * AverageDepth;
        }

        public override string ToString()
        {
            return $"Pond {Name} [L = {Length}; W = {Width}; D = {AverageDepth}]";
        }
    }
}
