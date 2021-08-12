namespace Dependency_Inversion_Principle
{
    public class MathOperations
    {
        private readonly ILogger _logger;

        public MathOperations(ILogger logger)
        {
            _logger = logger;
        }

        public double Add(double a, double b)
        {
            var result = a + b;
            _logger.Log($"{a}+{b}={result}");

            return result;
        }

        public double Substract(double a, double b)
        {
            var result = a - b;
            _logger.Log($"{a}-{b}={result}");

            return result;
        }
    }
}