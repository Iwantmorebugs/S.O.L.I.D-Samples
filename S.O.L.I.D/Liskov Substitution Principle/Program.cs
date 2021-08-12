using System;
using System.Collections.Generic;
using System.Linq;

namespace Liskov_Substitution_Principle
{
    internal class Program
    {
        private static void Main()
        {
            ICollection<Shape> shapes = new List<Shape>();
            shapes.Add(new CircleLiskov(2));
            shapes.Add(new SquareLiskov(3));
            shapes.Add(new LineNotLiskov());

            foreach (TwoDimensionalShape shape in shapes.Where(x => x is TwoDimensionalShape))
                Console.WriteLine($"Shape of {shape.GetType().Name} is {shape.GetArea()}");

            Console.ReadKey();
        }
    }
}