using Screpts.ConsumableItems;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Screpts.Inventory
{
    public class Cell : MonoBehaviour
    {
        private TMP_Text _count;
        private Item _item;
        private int _id;
        private bool _isOccupied = false;

        public bool IsOccupied => _isOccupied;

        public void SetId(int id)
        {
            _id = id;
        }

        public void SetItem(Item item)
        {
            _isOccupied = true;
            _count = item.TextCount;
            _item = item;
            _item.OnDeleted += FreeCell;
            _item.Icon.gameObject.SetActive(true);
            _count.text = item.Count.ToString();
            if (_item.Count > 1)
                _count.enabled = true;
            else
                _count.enabled = false;
        }

        public void FreeCell()
        {
            if(_item != null)
                _item.OnDeleted -= FreeCell;
            
            _isOccupied = false;
            _item = null;
            _count.enabled = false;
        }
    }
}