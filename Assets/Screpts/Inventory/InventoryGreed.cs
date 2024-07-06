using System.Collections.Generic;
using UnityEngine;

namespace Screpts.Inventory
{
    public class InventoryGreed : MonoBehaviour
    {
        private List<Cell> _cells = new List<Cell>();
        
        public List<Cell> Cells => _cells;

        public void AddListCells(List<Cell> cells)
        {
            _cells = cells;
        }
    }
}