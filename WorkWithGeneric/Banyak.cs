using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithGeneric
{
	class Banyak
	{
		private double vol;
		private string color;
		private string material;
		public double Vol
		{
			get => vol;
		}
		public Banyak(string _color, string _material, double _vol)
		{
			this.vol = _vol;
			this.color = _color;
			this.material= _material; 
		}
		public Banyak():this("срiбний", "алюмінiй", 0.0) { }
		public override string ToString()
		{
			return $"Баняк. Матеріал: {material}.Колір: {color}.Об'єм {vol} мл";
		}
	}
}
