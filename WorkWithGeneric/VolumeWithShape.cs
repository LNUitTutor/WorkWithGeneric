using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithGeneric
{
	abstract class ShapeWithVolume: IVolumable
	{
		protected static List<ShapeWithVolume> allInstances = new List<ShapeWithVolume>();
        public abstract double Volume();
		protected double vol;
        public double Vol 
		{ 
			get 
			{
				return vol;
			} 
		}
        public static ShapeWithVolume getMaxVolume()
		{
			ShapeWithVolume maxVol = allInstances[0];
			foreach(ShapeWithVolume s in allInstances)
			{
				if(s.Vol > maxVol.Vol)
				{
                    maxVol = s;
				}
			}
			return maxVol;
		}
		public static void printAll()
		{
			foreach (ShapeWithVolume s in allInstances)
			{
                Console.WriteLine(s);
            }
		}
		public static double getSumVolume()
		{
			double sum = 0;
			foreach (ShapeWithVolume s in allInstances)
			{
				sum += s.Vol;
			}
			return sum;
		}
	}
}
