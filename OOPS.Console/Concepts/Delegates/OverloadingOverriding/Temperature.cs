namespace OOPS.Console.Concepts.Delegates.OverloadingOverriding
{
    public class Temperature
    {
        private readonly double kelvin;

        public Temperature(double kelvin)
        {
            this.kelvin = kelvin;
        }

        // Implicit conversion to Celsius
        public static implicit operator Celsius(Temperature t)
        {
            double celsius = t.kelvin - 273.15;
            return new Celsius(celsius);
        }

        // Explicit conversion to Fahrenheit
        public static explicit operator Fahrenheit(Temperature t)
        {
            double fahrenheit = (t.kelvin - 273.15) * 9 / 5 + 32;
            return new Fahrenheit(fahrenheit);
        }
    }
    
    public class Celsius
    {
        private readonly double value;

        public Celsius(double value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return $"{value} °C";
        }
    }

    public class Fahrenheit
    {
        private readonly double value;

        public Fahrenheit(double value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return $"{value} °F";
        }
    }
}