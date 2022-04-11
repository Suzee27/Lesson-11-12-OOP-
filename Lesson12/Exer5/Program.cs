using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer5
{
    class Program
    {
        static void Main(string[] args)
        {
             Shape[] shape = new Shape[3];
            Circle circle = new Circle(5);
           
            //cir.Radius = 5;
            Rectangle rectangle = new Rectangle(circle.Radius, circle.Radius);
            

            Triangle triangle = new Triangle(circle.Radius, circle.Radius);
            

            shape[0] = circle;
            shape[1] = rectangle;
            shape[2] = triangle;

            double[] calculateArea = new double[3];
            calculateArea[0] = circle.CalculateSurface();
            calculateArea[1] = rectangle.CalculateSurface();
            calculateArea[2] = triangle.CalculateSurface();

            Console.WriteLine("The area of the circle, rectangle and triangle are {0}, {1}, {2} respectively", calculateArea[0], calculateArea[1], calculateArea[2]);
        }
    }
}
