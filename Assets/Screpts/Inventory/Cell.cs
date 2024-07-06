using Screpts.ConsumableItems;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Screpts.Inventory
{
    public class Cell : MonoBehaviour
    {
        [SerializeField] private TMP_Text _count;
        [SerializeField] private Transform _container;
        private Item _item;
        private int _id;
        private bool _isOccupied = false;

        public bool IsOccupied => _isOccupied;
        public Transform Container => _container;

        public void SetId(int id)
        {
            _id = id;
        }

        public void SetItem(Item item)
        {
            _item = item;
            _isOccupied = true;
            _item.Icon.gameObject.SetActive(true);
            _count.text = item.Count.ToString();
            if (_item.Count > 1)
                _count.enabled = true;
            else
                _count.enabled = false;
        }
    }
}