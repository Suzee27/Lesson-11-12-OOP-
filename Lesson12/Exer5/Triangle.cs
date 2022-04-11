using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer5
{
    class Triangle : Shape
    {
        public Triangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public override double CalculateSurface()
        {
            Area = Height * (Width/2);
            return Area;
        }
    }
}
