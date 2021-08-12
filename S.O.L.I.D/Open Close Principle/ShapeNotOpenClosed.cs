using System;

namespace Open_Close_Principle
{
    public class ShapeNotOpenClosed
    {
        private readonly double _radius;
        private readonly string _type;
        private readonly double _width;

        public ShapeNotOpenClosed(double radius, double width, string type)
        {
            _radius = radius;
            _type = type;
            _width = width;
        }

        public double GetArea()
        {
            switch (_type)
            {
                case "square":
                    return Math.Pow(_width, 2);
                case "circle":
                    return Math.PI * Math.Pow(_radius, 2);
            }

            return 0;
        }
    }
}