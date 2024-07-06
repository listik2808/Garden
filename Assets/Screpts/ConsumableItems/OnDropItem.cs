using UnityEngine;
using UnityEngine.EventSystems;

namespace Screpts.ConsumableItems
{
    public class OnDropItem : MonoBehaviour, IDropHandler
    {
        public void OnDrop(PointerEventData eventData)
        {
            Debug.Log("P145");
            if (transform.childCount == 0)
            {
                GameObject dropped = eventData.pointerDrag;
                DragDrop dragDrop = dropped.GetComponent<DragDrop>();
                dragDrop.SetPosition(transform);
            }

            //Cell newCell = dragDrop.GetComponent<Cell>();

            //if (newCell.IsOccupied == false)
            //{
            //    Debug.Log("P2");
            //    //dragDrop.SetPosition(newCell.transform);
            //}
            //else
            //{
            //    Debug.Log("P3");
            //    //PutBackPlace();
            //}
        }
    }
}