using System;

namespace OOPS.Console.Concepts.Delegates.FuncAndAction
{
    public class CalculatorConsumer
    {
        public CalculatorConsumer()
        {
            var calc = new CalculatorExample();
            calc.CalculationPerformed += CalculationPerformed;
            var someResult = calc.Add(20, 30);
        }

        private int CalculationPerformed(int a, int b)
        {
            //throw new NotImplementedException();
            return 1;
        }
    }
}