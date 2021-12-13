using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapeInShape
{
	public class Pyramid : Shape
	{
		public double baseEdge;
		public double height;

		public Pyramid(double baseSideLength, double h)
		{
			baseEdge = baseSideLength;
			height = h;
		}

		public Pyramid(Pyramid pyram)
		{
			this.baseEdge = pyram.baseEdge;
			this.height = pyram.height;
		}

		public double BaseEdge { get; set; }

		public double Height { get; set; }

		public override double CalculateVolume()
		{
			return Math.Pow(this.baseEdge, 2) * (this.height / 3);
		}
	}
}
