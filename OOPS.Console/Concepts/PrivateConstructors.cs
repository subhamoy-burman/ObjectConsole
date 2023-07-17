using System.Diagnostics;

namespace OOPS.Console.Concepts
{
    public class PrivateConstructors
    {
        public static PrivateConstructors Instance;
        private PrivateConstructors()
        {
            Debug.WriteLine("Private constructor called.");
        }

        public static void CreateInstance()
        {
            Instance = new PrivateConstructors();
            Debug.WriteLine("Instance created successfully.");
        }
    }
}