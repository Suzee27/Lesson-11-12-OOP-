using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer5
{
   public abstract class Shape
    {
        public abstract double CalculateSurface();

        private double width;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        private double area;

        public double Area
        {
            get { return area; }
            set { area = value; }
        }

    }
}
