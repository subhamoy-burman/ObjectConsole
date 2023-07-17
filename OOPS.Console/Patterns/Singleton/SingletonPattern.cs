using System;
using System.Linq;
using OOPS.Console.Concepts;

namespace OOPS.Console.Patterns.Singleton
{
    public class SingletonPattern
    {
        private SingletonPattern()
        {
            
        }
        
        private static string _instance;

        private string _randomString = "Random String";
        public static string Instance
        {
            get
            {
                if (string.IsNullOrEmpty(_instance))
                {
                    var newInstance = new SingletonPattern();
                    _instance = $"Current value {newInstance._randomString} {new Random(Int32.MaxValue).ToString()}";
                }

                return _instance;
            }
        }
    }
}