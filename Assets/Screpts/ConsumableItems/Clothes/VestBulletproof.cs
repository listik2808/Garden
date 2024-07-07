﻿using UnityEngine;

namespace Screpts.ConsumableItems.Clothes
{
    public class VestBulletproof : Item
    {
        [SerializeField] private int _armor = 3;

        public override int GetValue()
        {
            return _armor;
        }
    }
}