using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapeInShape
{
	public class RectangularCuboid : Shape
	{
		public double length;
		public double width;
		public double height;

		public RectangularCuboid(double l, double w, double h)
		{
			length = l;
			width = w;
			height = h;
		}

		public RectangularCuboid(RectangularCuboid reccub)
		{
			this.length = reccub.length;
			this.width = reccub.width;
			this.height = reccub.height;
		}

		public double Length { get; set; }

		public double Width { get; set; }

		public double Height { get; set; }

		public override double CalculateVolume()
		{
			return this.length * this.width * this.height;
		}
	}
}
