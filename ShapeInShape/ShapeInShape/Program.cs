using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInShape
{
    class Program
    {
        public static void Main()
        {
            var scholar = new Student("20191");
            var c = new Cube(10);
            var s = new Sphere(1);
            var a = new Answer(c.CalculateVolume(), s.CalculateVolume());
            var scholar1 = new Student("20219");
            var p = new Pyramid(2, 7);
            var rc = new RectangularCuboid(1, 2, 3);
            var a1 = new Answer(p.CalculateVolume(), rc.CalculateVolume());

            Console.WriteLine(String.Format("ID: {0}", scholar.ID));
            Console.WriteLine(String.Format("Cube \"c\" created."));
            Console.WriteLine(String.Format("The edge of cube \"c\" is: {0} inch(es)", c.edge));
            Console.WriteLine(String.Format("The volume of cube \"c\" is: {0} cubic inch(es)", c.CalculateVolume()));
            Console.WriteLine(String.Format("Sphere \"s\" created."));
            Console.WriteLine(String.Format("The radius of sphere \"s\" is: {0} inch(es)", s.radius));
            Console.WriteLine(String.Format("The volume of sphere \"s\" is: {0} cubic inch(es)", s.CalculateVolume()));
            Console.WriteLine(String.Format("Approximate number of sphere \"s\" spheres that will fit inside cube \"c\": {0}", a.NumberOfShapesFitted()));
            Console.WriteLine(String.Format("ID: {0}", scholar1.ID));
            Console.WriteLine(String.Format("The base edge of pyramid \"p\" is: {0} inch(es)", p.baseEdge));
            Console.WriteLine(String.Format("The height of pyramid \"p\" is: {0} inch(es)", p.height));
            Console.WriteLine(String.Format("The volume of pyramid \"p\" is: {0} cubic inch(es)", p.CalculateVolume()));
            Console.WriteLine(String.Format("Rectangular cuboid \"rc\" created."));
            Console.WriteLine(String.Format("The length of rectangular cuboid \"rc\" is: {0} inch(es)", rc.length));
            Console.WriteLine(String.Format("The width of rectangular cuboid \"rc\" is: {0} inch(es)", rc.width));
            Console.WriteLine(String.Format("The height of rectangular cuboid \"rc\" is: {0} inch(es)", rc.height));
            Console.WriteLine(String.Format("The volume of rectangular cuboid \"rc\" is: {0} cubic inch(es)", rc.CalculateVolume()));
            Console.WriteLine(String.Format("Approximate number of rectangular cuboid \"rc\" rectangular cuboids that will fit inside pyramid \"p\": {0}", a1.NumberOfShapesFitted()));
            Console.WriteLine(scholar.Log);
            Console.ReadLine();
        }
    }
}
