using Screpts.Inventory;
using Screpts.Spawn;
using System.Collections;
using UnityEngine;

namespace Screpts
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private OptionGreed _optionGreed;
        [SerializeField] private InventoryGreed _inventoryGreed;
        [SerializeField] private SpawnCell _spawnCell;

        private void Start()
        {
            _optionGreed.Initialization();
            _spawnCell.Create(_optionGreed.PrefabCell, _optionGreed.Container, _optionGreed.Countcell);
            _inventoryGreed.AddListCells(_spawnCell.Cells);
            _spawnCell.ActivateAllCells(_optionGreed.Countcell);
        }
    }
}