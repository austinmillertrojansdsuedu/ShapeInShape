using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapeInShape
{
	public class Cube : Shape
	{
		public double edge;

		public Cube(double sideLength)
		{
			edge = sideLength;
		}

		public Cube(Cube cub)
		{
			this.edge = cub.edge;
		}

		public double Edge { get; set; }


		public override double CalculateVolume()
		{
			return Math.Pow(this.edge, 3);
		}
	}
}
