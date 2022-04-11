using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer5
{
    class Circle: Shape
    {
        public Circle(double radius)
        {
            Height = radius;
            Width = radius;
            this.Radius = radius;
        }

        public override double CalculateSurface()
        {
            Area = Math.PI * Math.Pow(Radius, 2);
            return Area;
        }

        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        


    }
}
