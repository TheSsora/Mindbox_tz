using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Shapes
{
    public class Triangle : Shape
    {
        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightTriangle {get;}
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        private const double _power = 2.0d;
        private const double _accuracyСomparison = 0.0000001d;
        /// <summary>
        /// Класс принимает 3 стороны треугольника
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double sideA, double sideB, double sideC) 
        {
            if(sideA < _accuracyСomparison || sideB < _accuracyСomparison || sideC < _accuracyСomparison)
                throw new ArgumentException($"Значение стороны треугольника меньше {_accuracyСomparison}");

            double maxSide = Math.Max(sideA, Math.Max(sideB, sideC));
            double perimeter = sideA + sideB + sideC;

            if ((perimeter - maxSide) - maxSide < _accuracyСomparison)
                throw new ArgumentException($"Наибольшая сторона треугольника {maxSide} больше или равна сумме остальных сторон");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            IsRightTriangle = RightTriangleCheck();
        }
        private bool RightTriangleCheck()
        {
            return CalculatePifagorTheorem(SideA, SideB, SideC) 
                || CalculatePifagorTheorem(SideB, SideA, SideC) 
                || CalculatePifagorTheorem(SideC, SideA, SideB);
        }
        private bool CalculatePifagorTheorem(double hypotenuse, double sideA, double sideB)
        {            
            return Math.Abs(Math.Pow(hypotenuse, _power) - (Math.Pow(sideA, _power) + Math.Pow(sideB, _power))) < _accuracyСomparison;
        }
        /// <summary>
        /// Вычисляет площадь треугольника по 3 его сторонам
        /// </summary>
        /// <returns>Площадь</returns>
        public override double CalculateArea()
        {
            double semiP = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(semiP * (semiP - SideA) * (semiP - SideB) * (semiP - SideC));
        }
    }
}
