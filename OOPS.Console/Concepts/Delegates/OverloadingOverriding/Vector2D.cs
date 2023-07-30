namespace OOPS.Console.Concepts.Delegates.OverloadingOverriding
{
    public class Vector2D
    {
        private int _xAxis;
        private int _yAxis;
        public Vector2D(int xAxis, int yAxis)
        {
            _xAxis = xAxis;
            _yAxis = yAxis;
        }

        public static Vector2D operator +(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1._xAxis + v2._xAxis, v1._yAxis + v2._yAxis);
        }
    }
}