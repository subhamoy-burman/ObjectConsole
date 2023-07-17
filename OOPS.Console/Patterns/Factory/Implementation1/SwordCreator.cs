namespace OOPS.Console.Patterns.Factory.Implementation1
{
    public class SwordCreator : WeaponCreator
    {
        public override IWeapon CreateWeapon()
        {
            return new SwordWeapon();
        }
    }
}