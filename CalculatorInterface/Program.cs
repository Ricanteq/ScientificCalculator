
// using BankModal;
//
// var calculator = new ScientificCalculator();
// var returnResult = calculator.Addition(3 , 3);
// Console.WriteLine(returnResult);
// calculator.Percentage(200);

using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ScientificCalculator calculator = new ScientificCalculator();
            double result = calculator.Add(2.0, 3.0); // result = 5.0
            Console.WriteLine("Result: " + result);
        }
    }
}
