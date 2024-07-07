using Screpts.Inventory;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Screpts.ConsumableItems
{
    public class DragDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        [SerializeField] private RectTransform _rectTransform;
        [SerializeField] private CanvasGroup _canvasGroup;
        private Canvas _canvasMain;
        //private Transform _parentAfterDrag;
        private Cell _cell;

        private GameObject _itemBeingDragged;
        private Vector3 _startPosition;
        private Transform _startParent;

        public void Construct(Canvas canvas,Cell cell)
        {
            _canvasMain = canvas;
            _cell = cell;
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            _itemBeingDragged = gameObject;
            _startPosition = transform.position;
            _startParent = transform.parent;
            //transform.SetParent(transform.root);
            //transform.SetAsLastSibling();
            _canvasGroup.blocksRaycasts = false;
        }

        public void OnDrag(PointerEventData eventData)
        {
            _rectTransform.anchoredPosition += eventData.delta / _canvasMain.scaleFactor;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            _itemBeingDragged = null;
            if (transform.parent == _startParent)
            {
                transform.position = _startPosition;
            }
            _canvasGroup.blocksRaycasts = true;
        }

        public void SetPosition(Transform target)
        {
            _startParent = target.parent;
            transform.SetParent(target);
            transform.localPosition = Vector3.zero;
        }
    }
}