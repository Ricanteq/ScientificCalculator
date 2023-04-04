using System;

namespace CalculatorApp
{
    class ScientificCalculator : CalculatorBase
    {
        public double Power(double x, double y)
        {
            return Math.Pow(x, y);
        }

        public double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }
    }
}