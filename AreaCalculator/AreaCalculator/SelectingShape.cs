using AreaCalculator.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class SelectingShape : Shape
    {
        Shape Shape { get; }
        public SelectingShape(double radius)
        {
            Shape = new Circle(radius);
        }
        public SelectingShape(double sideA, double sideB, double sideC)
        {
            Shape = new Triangle(sideA, sideB, sideC);
        }
        public override double CalculateArea() => Shape.CalculateArea(); 
    }
}
