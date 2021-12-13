using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapeInShape
{
	public class Sphere : Shape
	{
		public double radius;

		public Sphere(double rad)
		{
			radius = rad;
		}

		public Sphere(Sphere spher)
		{
			this.radius = spher.radius;
		}

		public double Radius { get; set; }

		public override double CalculateVolume()
		{
			return Math.PI * Math.Pow(this.radius, 3) * 4/3;
		}
	}
}
