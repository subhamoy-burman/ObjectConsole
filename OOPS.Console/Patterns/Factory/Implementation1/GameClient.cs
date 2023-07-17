namespace OOPS.Console.Patterns.Factory.Implementation1
{
    public class GameClient 
    {
        public void CreateWeapon(WeaponCreator creator)
        {
            creator.CreateWeapon().Sharpen();
        }
    }
}