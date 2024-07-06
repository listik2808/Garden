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
        private Transform _parentAfterDrag;
        private Transform _currentPosition;
        private Cell _cell;

        public void Construct(Canvas canvas,Cell cell)
        {
            _canvasMain = canvas;
            _currentPosition = transform;
            _cell = cell;
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            _parentAfterDrag = transform.parent;
            transform.SetParent(transform.root);
            transform.SetAsLastSibling();
            _canvasGroup.interactable = false;
        }

        public void OnDrag(PointerEventData eventData)
        {
            _rectTransform.anchoredPosition += eventData.delta / _canvasMain.scaleFactor;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            Debug.Log("P4");

            transform.SetParent(_parentAfterDrag);
            _canvasGroup.interactable = true;
        }

        public void SetPosition(Transform transform)
        {
            _parentAfterDrag = transform;
            _currentPosition = transform;
        }
        public void PutBackPlace()
        {
            _parentAfterDrag = _currentPosition;
        }
    }
}