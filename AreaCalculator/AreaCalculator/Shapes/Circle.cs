using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; }
        private const double _power = 2.0d;
        /// <summary>
        /// Класс принимает в качестве параметра радиус окружности
        /// </summary>
        public Circle(double radius) 
        {
            if(radius <= 0)
                throw new ArgumentException("Значение радиуса окружности меньше или равно 0");

            Radius = radius;
        }
        /// <summary>
        /// Вычисляет и возращает площадь на основе радиуса
        /// </summary>
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, _power);
        }
    }
}
