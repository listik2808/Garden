namespace Screpts.ConsumableItems.Projectiles
{
    public class AutomaticBullets : Item
    {
        private int _countStac = 100;

        public override int GetValue()
        {
            if(Count < _countStac)
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