using UnityEngine;
using UnityEngine.UI;

namespace Screpts.ConsumableItems
{
    public abstract class Item : MonoBehaviour
    {
        [SerializeField] private protected Image _icon;
        [SerializeField] private protected float _weight;
        [SerializeField] private protected int _count;
        [SerializeField] private protected int _maxCount;

        public Image Icon => _icon;
        public int Count => _count;
    }
}