using Screpts.Inventory;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Screpts.ConsumableItems
{
    public class SlotDrop : MonoBehaviour, IDropHandler
    {
        [SerializeField] private Cell _cell;

        public void OnDrop(PointerEventData eventData)
        {
            if (_cell.IsOccupied == false)
            {
                GameObject dropped = eventData.pointerDrag;
                if(dropped.TryGetComponent(out DragDrop draggbleItem))
                {
                    draggbleItem.SetPosition(transform);
                    draggbleItem.SetCell(_cell);
                    _cell.SetItem(draggbleItem.Item);
                }
            }
        }
    }
}