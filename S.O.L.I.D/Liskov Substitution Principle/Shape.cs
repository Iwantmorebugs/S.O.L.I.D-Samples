using System;

namespace Liskov_Substitution_Principle
{
    public abstract class Shape
    {
    }

    public class CircleLiskov : TwoDimensionalShape
    {
        private readonly double _radius;

        public CircleLiskov(double radius)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }

    public class SquareLiskov : TwoDimensionalShape
    {
        private readonly double _width;

        public SquareLiskov(double width)
        {
            _width = width;
        }

        public override double GetArea()
        {
            return Math.Pow(_width, 2);
        }
    }

    public class LineNotLiskov : OneDimensionalShape
    {
    }

    // solution, create two other classes and take getarea to only the twodimensional one.


    public abstract class TwoDimensionalShape : Shape
    {
        public abstract double GetArea();
    }

    public abstract class OneDimensionalShape : Shape
    {
    }
}