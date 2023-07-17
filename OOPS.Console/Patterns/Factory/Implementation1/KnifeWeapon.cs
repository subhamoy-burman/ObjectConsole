using System.Diagnostics;

namespace OOPS.Console.Patterns.Factory.Implementation1
{
    public class KnifeWeapon : IWeapon
    {
        public void Sharpen()
        {
            System.Console.WriteLine("Knife is being sharpened");
        }
    }
}