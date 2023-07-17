namespace OOPS.Console.Patterns.Factory.Implementation1
{
    public class KnifeCreator : WeaponCreator
    {
        public override IWeapon CreateWeapon()
        {
            return new KnifeWeapon();
        }
    }
}