
namespace Screpts.ConsumableItems.Projectiles
{
    public class PistolBullet : Item
    {
        private int _countStac = 50;

        public override int GetValue()
        {
            if (Count < _countStac)
            {
                return _countStac - Count;
            }
            else
            {
                return _countStac;
            }
        }
    }
}