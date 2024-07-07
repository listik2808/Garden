using Screpts.Inventory;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Screpts.ConsumableItems
{
    public class DragDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        [SerializeField] private RectTransform _rectTransform;
        [SerializeField] private Item _item;
        private Canvas _canvasMain;
        private Cell _cell;

        private Vector3 _startPosition;
        private Transform _startParent;

        public Item Item => _item;

        public void Construct(Canvas canvas,Cell cell)
        {
            _canvasMain = canvas;
            _cell = cell;
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            _startPosition = transform.position;
            _startParent = transform.parent;
            transform.SetParent(transform.root);
            transform.SetAsLastSibling();
            _item.Icon.raycastTarget = false;
        }

        public void OnDrag(PointerEventData eventData)
        {
            _rectTransform.anchoredPosition += eventData.delta / _canvasMain.scaleFactor;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if (transform.parent == _startParent)
            {
                transform.position = _startPosition;
            }
            else
            {
                transform.SetParent(_startParent);
            }
            _item.Icon.raycastTarget = true;
        }

        public void SetPosition(Transform target)
        {
            _startParent = target;
            transform.SetParent(target);
            transform.localPosition = Vector3.zero;
        }

        public void SetCell(Cell cell)
        {
            _cell.FreeCell();
            _cell = cell;
        }
    }
}