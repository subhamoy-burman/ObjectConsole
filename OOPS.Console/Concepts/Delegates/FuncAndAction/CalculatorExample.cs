using System;

namespace OOPS.Console.Concepts.Delegates.FuncAndAction
{
    public class CalculatorExample
    {
        //public delegate int CalculateDelegate(int a, int b);

        //public event CalculateDelegate CalculationPerformed;

        public Func<int,int,int> CalculationPerformed;

        public int Add(int a, int b)
        {
            int result = a + b;
            CalculationPerformed.Invoke(a, b);
            return result;
        }
        
        public int Multiply(int a, int b)
        {
            int result = a * b;
            CalculationPerformed.Invoke(a, b);
            return result;
        }
    }
}