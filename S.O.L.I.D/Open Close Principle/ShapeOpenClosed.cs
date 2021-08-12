using System;

namespace Open_Close_Principle
{
    public abstract class ShapeOpenClosed
    {
        public abstract double GetArea();
    }

    public class Square : ShapeOpenClosed
    {
        private readonly double _width;

        public Square(double width)
        {
            _width = width;
        }

        public override double GetArea()
        {
            return Math.Pow(_width, 2);
        }
    }

    public class Circle : ShapeOpenClosed
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}