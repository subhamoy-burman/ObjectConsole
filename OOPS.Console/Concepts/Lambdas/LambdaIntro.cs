using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace OOPS.Console.Concepts.Lambdas
{
    public class LambdaIntro
    {
        public delegate int GetSum(int a, int b);

        public event GetSum GetSumEvent;

        public void PublishSum(int x, int y)
        {
            GetSumEvent?.Invoke(x,y);
        }

        public LambdaIntro()
        {
            int a = 5;
            int b = 6;

            int SumResult(int x, int y) => x + y;

            var result =SumResult(a, b);

            GetSum result2 = (int x, int y) =>  x + y ;

            result2(2, 30);
            
            Action<int> printNumber = (x) => {
                Debug.WriteLine("The value of x is " + x);
            };

            printNumber(a);
        }
    }

    public class Subscriber
    {
        public Subscriber()
        {
            var lambda = new LambdaIntro();
            lambda.GetSumEvent+= LambdaOnGetSumCall;
            
            lambda.PublishSum(10,20);
        }

        private int LambdaOnGetSumCall(int a, int b)
        {
            Debug.WriteLine("Result published");
            return 1;
        }
    }
}