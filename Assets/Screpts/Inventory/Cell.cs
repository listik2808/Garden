using Screpts.ConsumableItems;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Screpts.Inventory
{
    public class Cell : MonoBehaviour//,IDropHandler
    {
        private TMP_Text _count;
        private Item _item;
        private int _id;
        private bool _isOccupied = false;

        public bool IsOccupied => _isOccupied;

        //public void OnDrop(PointerEventData eventData)
        //{
        //    Debug.Log("P1");
        //    DragDrop dragDrop = eventData.pointerDrag.GetComponent<DragDrop>();
        //    if (_isOccupied ==false)
        //    {
        //        Debug.Log("P2");
        //        dragDrop.SetPosition(transform); 
        //    }
        //    else
        //    {
        //        Debug.Log("P3");
        //        dragDrop.PutBackPlace();
        //    }
        //}

        public void SetId(int id)
        {
            _id = id;
        }

        public void SetItem(Item item)
        {
            _count = item.TextCount;
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