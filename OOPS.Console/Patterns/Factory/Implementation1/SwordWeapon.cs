namespace OOPS.Console.Patterns.Factory.Implementation1
{
    public class SwordWeapon : IWeapon
    {
        public void Sharpen()
        {
            System.Console.WriteLine("Sword is being sharpened");
        }
    }
}