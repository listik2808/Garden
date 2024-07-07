using UnityEngine;

namespace Screpts.ConsumableItems.Clothes
{
    public class Cap : Item
    {
        [SerializeField] private int _armor = 3;

        public override int GetValue()
        {
            return _armor;
        }
    }
}