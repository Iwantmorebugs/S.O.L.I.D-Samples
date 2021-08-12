using System;

namespace Dependency_Inversion_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new ScreenLogger(); // new FileLogger("log.txt")
            var operations = new MathOperations(logger);

            operations.Add(2, 3);
            operations.Substract(8, 5);

            Console.ReadKey();
        }
    }
}
