using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapeInShape
{
	public class Answer
	{
		public double firstShape;
		public double secondShape;

		public Answer(double first, double second)
		{
			firstShape = first;
			secondShape = second;
		}

		public Answer(Answer ans)
		{
			this.firstShape = ans.firstShape;
			this.secondShape = ans.secondShape;
		}

		public double FirstShape { get; set; }

		public double SecondShape { get; set; }


		public double NumberOfShapesFitted()
		{
			return Math.Floor(this.firstShape / this.secondShape);
		}
	}
}
