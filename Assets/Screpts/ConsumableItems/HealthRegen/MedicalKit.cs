using UnityEngine;

namespace Screpts.ConsumableItems.HealthRegen
{
    public class MedicalKit : Item
    {
        [SerializeField] private int _regenHp = 50;

        public override int GetValue()
        {
            return _regenHp;
        }
    }
}