using Screpts.Inventory;
using System.Collections.Generic;
using UnityEngine;

namespace Screpts.Spawn
{
    public class SpawnCell : MonoBehaviour
    {
        private List<Cell> _cells = new List<Cell>();

        public List<Cell> Cells => _cells;

        public void Create(Cell cell,Transform container,int count)
        {
            int index = 0;
            while(count > 0)
            {
                Cell newCell = Instantiate(cell, container);
                index++;
                newCell.SetId(index++);
                newCell.gameObject.SetActive(false);
                _cells.Add(newCell);
                count--;
            }
        }

        public void ActivateAllCells(int count) 
        {
            for (int i = 0; i < _cells.Count; i++)
            {
                _cells[i].gameObject.SetActive(true);
            }
        }
    }
}