namespace CalculatorApp
{
    abstract class CalculatorBase : ICalculator
    {
        public virtual double Add(double x, double y)
        {
            return x + y;
        }

        public virtual double Subtract(double x, double y)
        {
            return x - y;
        }

        public virtual double Multiply(double x, double y)
        {
            return x * y;
        }

        public virtual double Divide(double x, double y)
        {
            return x / y;
        }
    }
}