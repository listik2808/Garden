using UnityEngine;
using UnityEngine.UI;

namespace Screpts.Inventory
{
    public class OptionGreed : MonoBehaviour
    {
        [SerializeField] private Cell _prefabCell;
        [SerializeField] private int _numberRows = 6;
        [SerializeField] private int _countCell = 30;
        [SerializeField] private GridLayoutGroup _layoutGroup;
        [SerializeField] private Transform _container;

        public int Countcell => _countCell;
        public Transform Container => _container;
        public Cell PrefabCell => _prefabCell;

        public void Initialization()
        {
            _layoutGroup.constraintCount = _numberRows;
        }
    }
}