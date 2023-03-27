using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithGeneric
{
    public abstract class Shape3D : IVolumable
    {
        public abstract double Volume();
        public abstract double BaseArea();
    }
    public class Cylinder : Shape3D
    {
        double r, h;
        public Cylinder(double radius = 1.0, double height = 1.0)
        {
            r = radius; h = height;
        }
        public override double BaseArea()
        {
            return Math.PI * r * r;
        }
        public override double Volume()
        {
            return this.BaseArea() * h;
        }
        public override string ToString()
        {
            return $"Cylinder(radius = {r}, height = {h})";
        }
    }
    public class Parallelepiped : Shape3D
    {
        double a, b, c;
        public Parallelepiped(double x = 1.0, double y = 1.0, double z = 1.0)
        {
            a = x; b = y; c = z;
        }
        public override double BaseArea()
        {
            return a * b;
        }
        public override double Volume()
        {
            return a * b * c;
        }
        public override string ToString()
        {
            return $"Parallelepiped [{a} x {b} x {c}]";
        }
    }
}
