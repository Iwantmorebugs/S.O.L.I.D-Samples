using System.IO;

namespace Dependency_Inversion_Principle
{
    public class FIleLogger : ILogger
    {
        private readonly string _filePath;

        public FIleLogger(string filePath)
        {
            _filePath = filePath;
        }

        public void Log(string message)
        {
            File.AppendAllText(_filePath, message + "\n");
        }
    }
}