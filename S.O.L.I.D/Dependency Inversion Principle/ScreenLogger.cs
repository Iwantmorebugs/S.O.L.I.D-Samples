using System;

namespace Dependency_Inversion_Principle
{
    public class ScreenLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}