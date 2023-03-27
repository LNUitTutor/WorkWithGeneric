using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithGeneric
{
	class Banyak : ShapeWithVolume
	{
		private double r;
		private double height;
		public Banyak() 
		{
			r = 0;
			height = 0;
			this.vol = this.Volume();
			allInstances.Add(this);
		}
		public Banyak(double _r, double _height)
		{
			this.r = _r;
			this.height = _height;
			this.vol = this.Volume();
			allInstances.Add(this);
		}
		public override double Volume()
		{
			return Math.PI * this.r * this.r * this.height;
		}
		public override string ToString()
		{
			return $"Я баняк. Я можу вмістити в себе {this.Volume()} мл зупи :)";
		}
	}
}
