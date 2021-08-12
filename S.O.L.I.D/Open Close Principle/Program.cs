using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Open_Close_Principle
{
    internal class Program
    {
        private static void Main()
        {
            //NOT FOLLOWING OPEN CLOSED PRINCIPLE
            var mySquare = new ShapeNotOpenClosed(0, 5, "square");
            var myCircle = new ShapeNotOpenClosed(3, 0, "circle");

            Console.WriteLine($"Area of the square: {mySquare.GetArea()}");
            Console.WriteLine($"Area of the circle: {myCircle.GetArea()}");
            Console.ReadKey();

            //FOLLOWING OPEN CLOSED PRINCIPLE
            ICollection<ShapeOpenClosed> shapes = new Collection<ShapeOpenClosed>();
            shapes.Add(new Circle(2));
            shapes.Add(new Square(4));

            foreach (var shape in shapes) Console.WriteLine($"Area of the {shape.GetType().Name}: {shape.GetArea()}");
            Console.ReadKey();
        }
    }
}