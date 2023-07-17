namespace OOPS.Console.Concepts
{
    public class StaticConstructors
    {
        private static int _count;
        static StaticConstructors()
        {
            _count = 0;
        }

        public StaticConstructors()
        {
            _count++;
        }

        public static int GetCount()
        {
            return _count;
        }
    }
}